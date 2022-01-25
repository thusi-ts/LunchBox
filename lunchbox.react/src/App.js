import Header from "./components/Header";
import ProductList from "./components/ProductList";
import Cart from "./components/Cart";

function App() {
  return (
    <div className="grid-container">
        <header-container>
          <Header />
        </header-container>
        <navigation-container>Navigation</navigation-container>
        <main-container>
          <div class="main-header">Kylling & Co Viborg, Gravene</div>
          <div class="main-inner-wrapper">
            <div class="main">
              <ProductList />
            </div>
            <div class="cart">
            <Cart />
            </div>
          </div>
        </main-container>
    </div>
  );
}

export default App;
