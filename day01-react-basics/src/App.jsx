const students = [
  { name: 'Alice', grade : 85 , subject: 'Math' },
  { name: 'Bob', grade : 92 , subject: 'Science' },
  { name: 'Charlie', grade : 78 , subject: 'History' },
  { name: 'David', grade : 90 , subject: 'Math' },
  { name: 'Eve', grade : 88 , subject: 'Science' }
];

function StudentCard ({ name, grade, subject }) {
  return (
    <div className="student-card">
      <h2>{name}</h2>
      <p>Grade: {grade}</p>
      <p>Subject: {subject}</p>
    </div>
  );
}

function DateToday () {
  const today = new Date();
  const options = { year: 'numeric', month: 'long', day: 'numeric' };
  return <p>Today's Date: {today.toLocaleDateString(undefined, options)}</p>;
}

function App() {
  return (
    <div>
      <h1>Student Grades</h1>
      <div className="student-list">
        {students.map((student, index) => (
          <StudentCard 
            key={index}
            name={student.name}
            grade={student.grade}
            subject={student.subject}
          />
        ))}
      </div>
      <DateToday />
    </div>
  );
}

export default App;