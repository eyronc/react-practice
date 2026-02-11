interface StarProps {
  x: number;
  y: number;
}

export const Star = ({ x, y }: StarProps) => {
  return (
    <div
      style={{
        position: 'absolute',
        left: `${x}px`,
        top: `${y}px`,
        width: '30px',
        height: '30px',
        backgroundColor: '#FFD700',
        borderRadius: '50%',
        boxShadow: '0 0 10px #FFD700',
      }}
    >
      ⭐
    </div>
  );
};