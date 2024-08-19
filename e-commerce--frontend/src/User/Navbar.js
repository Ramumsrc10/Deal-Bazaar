import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';

const Navbar = () => {
  return (
    <nav className="navbar">
      <div className="navbar-content">
        <div className="logo">
          <Link to="/">
            <span className="deal">DEAL BAZAA₹</span> 
          </Link>
        </div>
        <div className="search-bar">
          <input type="text" placeholder="Search for products..." />
          <button type="button">search</button>
        </div>
        <div className="nav-account">
          <ul className="nav-links">
            <li><Link to="/products">Products</Link></li>
            <li><Link to="/services">Services</Link></li>
            <li><Link to="/specials">Specials</Link></li>
            <li><Link to="/help">Help</Link></li>
            <li><Link to="/signin">Sign In</Link></li>
            <li><Link to="/cart">Cart</Link></li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
