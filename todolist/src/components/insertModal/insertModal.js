import { useState } from 'react'
import './insertModal.css'

export const InsertModal = ({array, setArray, setModal}) => {

    const [valueCreate, setValueCreate] = useState('')

    function createTask(e){
        e.preventDefault();
        let newList = array;
        newList.push({
            id:Math.random(),
            name:valueCreate,
            status:false
        })

        setArray([
            ...newList
        ])

        setModal(false);
    }

    return (
        <form onSubmit={createTask} className='main-list modal-background'>
            <h2>Descreva sua tarefa</h2>

            <textarea className='input-create' value={valueCreate} onChange={(e)=>setValueCreate(e.target.value)}/> 
            <button className='button-create' type='submit'>Confirmar tarefa</button>
        </form>
    )
}