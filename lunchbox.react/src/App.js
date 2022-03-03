import { useState, useEffect } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

import Header from "./components/Header";
import Navigation from "./components/Navigation";

// pages
import Splash from "./components/Splash";
import Index from "./components/pages/Index";
import Store from "./components/pages/Store";
import Info from "./components/pages/Info";
import ForgotPassword from "./components/pages/ForgotPassword";
import Login from "./components/pages/Login";
import Register from "./components/pages/Register";
import Order from "./components/pages/Order";

function App() {

  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {

    setTimeout(() => { 
      setIsLoading(false);
    }, 5000)
  });

  //https://medium.com/@arashdeeps2004/splash-screen-in-react-js-using-react-redux-8e75871482e9

  if(isLoading){
    return ( <Splash /> );
  }
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
        
          <Routes>
              <Route path = "/" exact element = {<Index />} ></Route>
              <Route path = "/pages" element = {<Index />} ></Route>
              <Route path = "/pages/store" element = {<Store />} ></Route>
              <Route path = "/pages/info" element = {<Info />}></Route>
              <Route path = "/pages/forgotPassword" element = {<ForgotPassword />}></Route>
              <Route path = "/pages/login" element = {<Login />}></Route>
              <Route path = "/pages/order" element = {<Order />}></Route>
              <Route path = "/pages/register" element = {<Register />}></Route>
          </Routes>
        </main-container>
      </div>
      </Router>
  );
}

export default App;
