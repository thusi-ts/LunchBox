import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class StoreList extends Component {
  render() {
    return (
      <div className="store-list-wrapper">
            <div className="main-title">Leverandør</div>
            <div className="store-list">
                <div className="image"></div>
                <div className="info">
                    <Link to='/pages/store'> <h4>Kylling &amp; Co Viborg, Gravene</h4> </Link>
                    
                    <p>Velkommen til Kylling &amp; Co – En verden af smag<br />bagels, salat, burger, kyllingespyd, kartofel og kyllinger.</p><br />
                    <p>Adresse: Gravene 4</p><p class="opentime">Åbnings tid: 10:30 - 19:00</p>
                </div>
            </div>
      </div>
    )
  }
}
