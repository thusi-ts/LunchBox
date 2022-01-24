import Header from "./components/Header";
import ProductList from "./components/ProductList";

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
            <div class="cart">fsfsf sfsfsf sf fsfsf sf sfsf sf sfs sfsf sfs fsf sf sf sf sdfsdfs sdf sf sfsf sdf sdf sf sfs fsdf sdf sf sfsd fsdf sdf sdffsdfsdf sf sdf sfsdf sdf sdf</div>
          </div>
        </main-container>
    </div>
  );
}

export default App;
