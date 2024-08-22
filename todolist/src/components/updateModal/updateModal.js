import { useState } from "react";

export const UpdateModal = ({item, array ,setArray, setModal}) => {

    const [newTask, setNewTask] = useState(item.name)

    function alterTask(){
        let index = array.findIndex((element)=>element.id === item.id)
        array[index] = {
            id: item.id,
            name: newTask,
            status: item.status
        }
        setArray([
            ...array
        ])
        setModal(false)
    }

    return(
        <form onSubmit={alterTask} className='main-list modal-background'>
            <h2>Alterar tarefa</h2>

            <textarea className='input-create' value={newTask} onChange={(e)=>setNewTask(e.target.value)}/> 
            <button className='button-create' type='submit'>Alterar tarefa</button>
        </form>
    )
}