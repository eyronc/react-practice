import { useState, useEffect, useRef } from 'react';
import { Star as StarComponent } from './Star';
import { Basket } from './Basket';
import { useKeyboard } from '../hooks/useKeyboard';
import type { Star } from '../types';

const GAME_WIDTH = 800;
const GAME_HEIGHT = 600;
const BASKET_WIDTH = 100;
const BASKET_HEIGHT = 30;
const BASKET_SPEED = 5;

export const Game = () => {
  const [basketX, setBasketX] = useState(GAME_WIDTH / 2 - BASKET_WIDTH / 2);
  const [stars, setStars] = useState<Star[]>([
    { id: 1, x: Math.random() * (GAME_WIDTH - 30), y: 0, speed: 2 },
  ]);
  const [score, setScore] = useState(0);
  const [gameOver, setGameOver] = useState(false);
  const [missedStars, setMissedStars] = useState(0);

  const keys = useKeyboard();
  const requestRef = useRef<number>(0);
  const starIdCounter = useRef(2);

  useEffect(() => {
    if (gameOver) return;

    const gameLoop = () => {
      setBasketX((prev) => {
        let newX = prev;
        if (keys.left) newX -= BASKET_SPEED;
        if (keys.right) newX += BASKET_SPEED;
        return Math.max(0, Math.min(GAME_WIDTH - BASKET_WIDTH, newX));
      });

      setStars((prevStars) => {
        return prevStars.map((star) => {
          const newY = star.y + star.speed;

          if (
            newY >= GAME_HEIGHT - 50 &&
            newY <= GAME_HEIGHT - 20 &&
            star.x >= basketX - 15 &&
            star.x <= basketX + BASKET_WIDTH - 15
          ) {
            setScore((s) => s + 1);
            return {
              ...star,
              y: 0,
              x: Math.random() * (GAME_WIDTH - 30),
            };
          }

          if (newY > GAME_HEIGHT) {
            setMissedStars((m) => m + 1);
            return {
              ...star,
              y: 0,
              x: Math.random() * (GAME_WIDTH - 30),
            };
          }

          return { ...star, y: newY };
        });
      });

      requestRef.current = requestAnimationFrame(gameLoop);
    };

    requestRef.current = requestAnimationFrame(gameLoop);

    return () => {
      if (requestRef.current) {
        cancelAnimationFrame(requestRef.current);
      }
    };
  }, [keys, basketX, gameOver]);

  useEffect(() => {
    if (missedStars >= 3) {
      setGameOver(true);
    }
  }, [missedStars]);

  useEffect(() => {
    if (gameOver) return;

    const interval = setInterval(() => {
      if (stars.length < 5) {
        setStars((prev) => [
          ...prev,
          {
            id: starIdCounter.current++,
            x: Math.random() * (GAME_WIDTH - 30),
            y: 0,
            speed: 2 + Math.random() * 2,
          },
        ]);
      }
    }, 3000);

    return () => clearInterval(interval);
  }, [stars.length, gameOver]);

  const handleRestart = () => {
    setBasketX(GAME_WIDTH / 2 - BASKET_WIDTH / 2);
    setStars([{ id: 1, x: Math.random() * (GAME_WIDTH - 30), y: 0, speed: 2 }]);
    setScore(0);
    setMissedStars(0);
    setGameOver(false);
    starIdCounter.current = 2;
  };

  return (
    <div
      style={{
        position: 'relative',
        width: `${GAME_WIDTH}px`,
        height: `${GAME_HEIGHT}px`,
        backgroundColor: '#1a1a2e',
        margin: '20px auto',
        border: '3px solid #16213e',
        overflow: 'hidden',
      }}
    >
      {/* Score Display */}
      <div
        style={{
          position: 'absolute',
          top: '10px',
          left: '10px',
          color: 'white',
          fontSize: '24px',
          fontWeight: 'bold',
          zIndex: 10,
        }}
      >
        Score: {score}
      </div>

      {/* Lives Display */}
      <div
        style={{
          position: 'absolute',
          top: '10px',
          right: '10px',
          color: 'white',
          fontSize: '24px',
          fontWeight: 'bold',
          zIndex: 10,
        }}
      >
        Lives: {3 - missedStars}
      </div>

      {/* Game Over Screen */}
      {gameOver && (
        <div
          style={{
            position: 'absolute',
            top: 0,
            left: 0,
            width: '100%',
            height: '100%',
            backgroundColor: 'rgba(0, 0, 0, 0.8)',
            display: 'flex',
            flexDirection: 'column',
            justifyContent: 'center',
            alignItems: 'center',
            zIndex: 100,
          }}
        >
          <h1 style={{ color: 'white', fontSize: '48px', margin: '20px' }}>
            Game Over!
          </h1>
          <p style={{ color: 'white', fontSize: '24px', margin: '20px' }}>
            Final Score: {score}
          </p>
          <button
            onClick={handleRestart}
            style={{
              padding: '15px 30px',
              fontSize: '20px',
              backgroundColor: '#4CAF50',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer',
            }}
          >
            Restart
          </button>
        </div>
      )}

      {/* Stars */}
      {stars.map((star) => (
        <StarComponent key={star.id} x={star.x} y={star.y} />
      ))}

      {/* Basket */}
      <Basket x={basketX} width={BASKET_WIDTH} height={BASKET_HEIGHT} />

      {/* Instructions */}
      <div
        style={{
          position: 'absolute',
          bottom: '60px',
          left: '50%',
          transform: 'translateX(-50%)',
          color: 'white',
          fontSize: '14px',
          opacity: 0.7,
        }}
      >
        Use ← → arrow keys to move
      </div>
    </div>
  );
};