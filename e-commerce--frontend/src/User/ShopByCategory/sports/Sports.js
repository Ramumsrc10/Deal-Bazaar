import React from 'react';
import './Sports.css'; // Make sure you create/update this CSS file

export default function Sports() {
  const categories = [
    { title: 'Fitness Equipment', imgSrc: 'path/to/fitness-equipment.jpg' },
    { title: 'Outdoor Gear', imgSrc: 'path/to/outdoor-gear.jpg' },
    { title: 'Sports Apparel', imgSrc: 'path/to/sports-apparel.jpg' },
    { title: 'Cycling', imgSrc: 'path/to/cycling.jpg' },
    { title: 'Yoga', imgSrc: 'path/to/yoga.jpg' },
    { title: 'Running', imgSrc: 'path/to/running.jpg' },
    { title: 'Team Sports', imgSrc: 'path/to/team-sports.jpg' },
    { title: 'More', imgSrc: 'path/to/more.jpg' },
  ];

  return (
    <div className="sports-products">
      {categories.map((category, index) => (
        <div key={index} className="card">
          <img src={category.imgSrc} alt={category.title} className="card-image" />
          <div className="card-content">
            <h3 className="card-title">{category.title}</h3>
            <button className="shop-now-button">Shop Now</button>
          </div>
        </div>
      ))}
    </div>
  );
}
