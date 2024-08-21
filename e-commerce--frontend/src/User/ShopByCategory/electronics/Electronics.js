import React from 'react';
import './Electronics.css'; // Make sure you create/update this CSS file
import axios from 'axios';

export default function Electronics() {
  const categories = [
    { title: 'Smartphones', imgSrc: 'path/to/smartphones.jpg' },
    { title: 'Laptops', imgSrc: 'path/to/laptops.jpg' },
    { title: 'Tablets', imgSrc: 'path/to/tablets.jpg' },
    { title: 'Smart TVs', imgSrc: 'path/to/smarttvs.jpg' },
    { title: 'Headphones', imgSrc: 'path/to/headphones.jpg' },
    { title: 'Speakers', imgSrc: 'path/to/speakers.jpg' },
    { title: 'Smartwatches', imgSrc: 'path/to/smartwatches.jpg' },
    { title: 'Cameras', imgSrc: 'path/to/cameras.jpg' },
    { title: 'More', imgSrc: 'path/to/more.jpg' },
  ];

  const ShopNowHandler=()=>{
  }

  return (
    <div className="electronics-products">
      {categories.map((category, index) => (
        <div key={index} className="card">
          <img src={category.imgSrc} alt={category.title} className="card-image" />
          <div className="card-content">
            <h3 className="card-title">{category.title}</h3>
            <button className="shop-now-button" onClick={()=>ShopNowHandler(category.title)} >Shop Now</button>
          </div>
        </div>
      ))}
    </div>
  );
}
