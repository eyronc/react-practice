import React, { useState } from "react";

function App() {
  const [students, setStudents] = useState([
    { id: 1, name: "Aaron", grade: 90, subject: "Math" },
    { id: 2, name: "Bianca", grade: 85, subject: "Science" },
    { id: 3, name: "Carlos", grade: 88, subject: "History" },
  ]);

  const [search, setSearch] = useState("");
  const [subjectFilter, setSubjectFilter] = useState("All");
  const [showForm, setShowForm] = useState(false);

  const [newStudent, setNewStudent] = useState({
    name: "",
    grade: "",
    subject: "Math",
  });

  const filteredStudents = students.filter((student) => {
    const matchesName = student.name
      .toLowerCase()
      .includes(search.toLowerCase());

    const matchesSubject =
      subjectFilter === "All" || student.subject === subjectFilter;

    return matchesName && matchesSubject;
  });

  const totalShown = filteredStudents.length;

  const averageGrade =
    totalShown === 0
      ? 0
      : (
          filteredStudents.reduce((sum, s) => sum + s.grade, 0) /
          totalShown
        ).toFixed(2);

  const handleAddStudent = (e) => {
    e.preventDefault();

    if (!newStudent.name || !newStudent.grade) return;

    const studentToAdd = {
      id: Date.now(),
      name: newStudent.name,
      grade: Number(newStudent.grade),
      subject: newStudent.subject,
    };

    setStudents((prev) => [...prev, studentToAdd]);

    setNewStudent({
      name: "",
      grade: "",
      subject: "Math",
    });
  };

  const handleDelete = (id) => {
    setStudents((prev) => prev.filter((student) => student.id !== id));
  };

  return (
    <div style={{ padding: "20px", maxWidth: "600px", margin: "auto" }}>
      <h2>Student Dashboard</h2>

      <input
        type="text"
        placeholder="Search by name..."
        value={search}
        onChange={(e) => setSearch(e.target.value)}
        style={{ width: "100%", padding: "8px", marginBottom: "10px" }}
      />

      <select
        value={subjectFilter}
        onChange={(e) => setSubjectFilter(e.target.value)}
        style={{ width: "100%", padding: "8px", marginBottom: "10px" }}
      >
        <option value="All">All</option>
        <option value="Math">Math</option>
        <option value="Science">Science</option>
        <option value="History">History</option>
      </select>

      <button onClick={() => setShowForm((prev) => !prev)}>
        {showForm ? "Hide Form" : "Add Student"}
      </button>

      {showForm && (
        <form onSubmit={handleAddStudent} style={{ marginTop: "10px" }}>
          <input
            type="text"
            placeholder="Name"
            value={newStudent.name}
            onChange={(e) =>
              setNewStudent((prev) => ({ ...prev, name: e.target.value }))
            }
            style={{ width: "100%", padding: "8px", marginBottom: "5px" }}
          />

          <input
            type="number"
            placeholder="Grade"
            value={newStudent.grade}
            onChange={(e) =>
              setNewStudent((prev) => ({ ...prev, grade: e.target.value }))
            }
            style={{ width: "100%", padding: "8px", marginBottom: "5px" }}
          />

          <select
            value={newStudent.subject}
            onChange={(e) =>
              setNewStudent((prev) => ({ ...prev, subject: e.target.value }))
            }
            style={{ width: "100%", padding: "8px", marginBottom: "5px" }}
          >
            <option value="Math">Math</option>
            <option value="Science">Science</option>
            <option value="History">History</option>
          </select>

          <button type="submit">Add</button>
        </form>
      )}

      <div style={{ marginTop: "15px" }}>
        <strong>Total Shown:</strong> {totalShown} <br />
        <strong>Average Grade:</strong> {averageGrade}
      </div>

      {filteredStudents.map((student) => (
        <div
          key={student.id}
          style={{
            border: "1px solid #ccc",
            padding: "10px",
            marginTop: "10px",
            borderRadius: "5px",
          }}
        >
          <h4>{student.name}</h4>
          <p>Grade: {student.grade}</p>
          <p>Subject: {student.subject}</p>
          <button onClick={() => handleDelete(student.id)}>Delete</button>
        </div>
      ))}
    </div>
  );
}

export default App;