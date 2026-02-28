function UserCard({ user, onSelect }) {
  return (
    <div
      onClick={() => onSelect(user.id)}
      style={{
        border: "1px solid #ccc",
        padding: "12px",
        borderRadius: "8px",
        marginBottom: "10px",
        cursor: "pointer",
      }}
    >
      <h3>{user.name}</h3>
      <p>{user.email}</p>
      <p>{user.company.name}</p>
    </div>
  );
}

export default UserCard;