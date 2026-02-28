import { useState, useEffect, useMemo } from "react";
import useFetch from "./hooks/useFetch";
import UserCard from "./components/UserCard";
import PostList from "./components/PostList";

const USERS_URL = "https://jsonplaceholder.typicode.com/users";

function App() {
  const [search, setSearch] = useState("");
  const [selectedUserId, setSelectedUserId] = useState(null);

  const {
    data: users,
    loading: usersLoading,
    error: usersError,
  } = useFetch(USERS_URL);

  const {
    data: posts,
    loading: postsLoading,
    error: postsError,
  } = useFetch(
    selectedUserId
      ? `https://jsonplaceholder.typicode.com/posts?userId=${selectedUserId}`
      : null
  );

  useEffect(() => {
    document.title = search
      ? `Searching: ${search}`
      : "Live User Explorer";
  }, [search]);

  const filteredUsers = useMemo(() => {
    if (!users) return [];
    return users.filter((user) =>
      user.name.toLowerCase().includes(search.toLowerCase())
    );
  }, [users, search]);

  return (
    <div style={{ padding: "20px", maxWidth: "700px", margin: "auto" }}>
      <h1>Live User Explorer</h1>

      <input
        type="text"
        placeholder="Search users..."
        value={search}
        onChange={(e) => setSearch(e.target.value)}
        style={{ width: "100%", padding: "8px", marginBottom: "15px" }}
      />

      {usersLoading && <p>Loading users...</p>}
      {usersError && <p style={{ color: "red" }}>Error: {usersError}</p>}

      {filteredUsers.map((user) => (
        <UserCard
          key={user.id}
          user={user}
          onSelect={setSelectedUserId}
        />
      ))}

      {selectedUserId && (
        <div style={{ marginTop: "30px" }}>
          <h2>User Posts</h2>

          {postsLoading && <p>Loading posts...</p>}
          {postsError && (
            <p style={{ color: "red" }}>Error: {postsError}</p>
          )}

          {posts && <PostList posts={posts} />}
        </div>
      )}
    </div>
  );
}

export default App;