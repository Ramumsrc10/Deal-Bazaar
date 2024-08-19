import logo from './logo.svg';
import { BrowserRouter,Routes,Route } from 'react-router-dom';
import './App.css';
import Navbar from './User/Navbar';
function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          
          <Route path='/' element={<Navbar/>}>
  
          </Route>


        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
