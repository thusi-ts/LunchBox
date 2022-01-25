import React, { Component } from 'react'
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";

import Header from "./components/Header";
import Splash from "./components/Splash";
import Navigation from "./components/Navigation";

// pages
import Index from "./components/pages/Index";
import Info from "./components/pages/Info";
import ForgotPassword from "./components/pages/ForgotPassword";
import Login from "./components/pages/Login";
import Register from "./components/pages/Register";


function App() {
  return (
    <Router>
      <div className="grid-container">
        <header-container>
          <Header />
        </header-container>
        <navigation-container>
          <Navigation />
        </navigation-container>
        <main-container>
          <Switch> 
              <Route path = "/pages/" exact component = {Index}></Route>
              <Route path = "/pages/info" exact component = {Info}></Route>
              <Route path = "/pages/forgotPassword" component = {ForgotPassword}></Route>
              <Route path = "/pages/login" component = {Login}></Route>
              <Route path = "/pages/register" component = {Register}></Route>
          </Switch>
        </main-container>
      </div>
    </Router>
  );
}

 

export default App;
