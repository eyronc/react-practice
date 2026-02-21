import { useState, useEffect } from 'react';

interface KeyState {
  left: boolean;
  right: boolean;
}

export const useKeyboard = (): KeyState => {
  const [keys, setKeys] = useState<KeyState>({
    left: false,
    right: false,
  });

  useEffect(() => {
    const handleKeyDown = (e: KeyboardEvent) => {
      if (e.key === 'ArrowLeft') {
        setKeys((prev) => ({ ...prev, left: true }));
      }
      if (e.key === 'ArrowRight') {
        setKeys((prev) => ({ ...prev, right: true }));
      }
    };

    const handleKeyUp = (e: KeyboardEvent) => {
      if (e.key === 'ArrowLeft') {
        setKeys((prev) => ({ ...prev, left: false }));
      }
      if (e.key === 'ArrowRight') {
        setKeys((prev) => ({ ...prev, right: false }));
      }
    };

    window.addEventListener('keydown', handleKeyDown);
    window.addEventListener('keyup', handleKeyUp);

    return () => {
      window.removeEventListener('keydown', handleKeyDown);
      window.removeEventListener('keyup', handleKeyUp);
    };
  }, []);

  return keys;
};