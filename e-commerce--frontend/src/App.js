import logo from './logo.svg';
import { BrowserRouter,Routes,Route } from 'react-router-dom';
import './App.css';
import Navbar from './User/Navbar';
import Landpage from './User/Landpage';
import Electronics from './User/ShopByCategory/electronics/Electronics';
import Fashion from './User/ShopByCategory/fashion/Fashion';
import HomeAndKitchen from './User/ShopByCategory/HandK/HomeAndKitchen';
import Sports from './User/ShopByCategory/sports/Sports';
function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>   
          <Route path='/' element={<Navbar/>}>
          <Route index element={<Landpage/>} />
          <Route path='electronics' element={<Electronics/>} />
          <Route path='fashion' element={<Fashion/>} />
          <Route path='handk' element={<HomeAndKitchen/>} />
          <Route path='sports' element={<Sports/>} />
          </Route>

        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
