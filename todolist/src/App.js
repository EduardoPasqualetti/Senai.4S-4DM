import { useEffect, useState } from 'react';
import { FaSearch } from "react-icons/fa";
import './App.css';
import { capitalizeFirstLetter, getRightDate } from './services/utils';
import { Task } from './components/task/task';
import { InsertModal } from './components/insertModal/insertModal';
function App() {
  const [search, setSearch] = useState('');
  const [insertModal, setInsertModal] = useState(false);
  const [array, setArray] = useState([])
  const [searchArray, setSearchArray] = useState([])
  const week = capitalizeFirstLetter(getRightDate({ weekday: 'long' }));
  const day = capitalizeFirstLetter(getRightDate({ day: '2-digit' }))
  const month = capitalizeFirstLetter(getRightDate({ month: 'long' }))


  function searchTasks() {
    if (search.length < 1) {
      return
    }
    let searchArray = array.filter(task => task.name.includes(search))
    setSearchArray([
      ...searchArray
    ])
  }


  useEffect(() => {
    searchTasks()
  }, [search, array])


  return (
    <main className="container">

      { insertModal ? <InsertModal array={array} setArray={setArray} setModal={setInsertModal} /> : null}

      <div className='main-list'>
        <h1>{week}, <span className='text-purple'>{day}</span> de {month}</h1>
        <label className='label-search' htmlFor='search'>
          <FaSearch />
          <input id='search' type='text' placeholder='Procurar tarefa' value={search} onChange={(e) => setSearch(e.target.value)} />
        </label>

        <div className='container-tasks'>
          {
            search.length > 0 ?
            searchArray.map((item) => {
                return <Task key={item.id} item={item} array={array} setArray={setArray} />
              })
              :
              array.map((item) => {
                return <Task key={item.id} item={item} array={array} setArray={setArray} />
              })
          }
        </div>
      </div>
      <div className='container-button'>
        <button className='button-new' onClick={() => setInsertModal(true)}>
          Nova tarefa
        </button>
      </div>
    </main>
  );
}

export default App;
