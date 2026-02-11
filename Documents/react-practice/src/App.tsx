import './App.css';
import { Game } from './components/Game';

function App() {
  return (
    <div className="App">
      <h1 style={{ textAlign: 'center', color: '#333' }}>
        Catch the Falling Stars!
      </h1>
      <Game />
    </div>
  );
}

export default App;