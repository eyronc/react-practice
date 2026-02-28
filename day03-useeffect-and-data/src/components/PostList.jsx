function PostList({ posts }) {
  return (
    <div style={{ marginTop: "20px" }}>
      {posts.map((post) => (
        <div key={post.id} style={{ marginBottom: "12px" }}>
          <h4>{post.title}</h4>
          <p>{post.body}</p>
        </div>
      ))}
    </div>
  );
}

export default PostList;