interface BasketProps {
  x: number;
  width: number;
  height: number;
}

export const Basket = ({ x, width, height }: BasketProps) => {
  return (
    <div
      style={{
        position: 'absolute',
        left: `${x}px`,
        bottom: '20px',
        width: `${width}px`,
        height: `${height}px`,
        backgroundColor: '#8B4513',
        borderRadius: '0 0 10px 10px',
        border: '3px solid #654321',
      }}
    />
  );
};