import React, { useState } from "react";

function App() {
  const [start, setStart] = useState<number>(1);
  const [end, setEnd] = useState<number>(20);
  const [result, setResult] = useState<string | null>(null);
  const [fizzBuzzList, setFizzBuzzList] = useState<string[]>([]);

  const handleCheck = async () => {
    try {
      const res = await fetch(`/api/fizzbuzz?start=${start}&end=${end}`);
      const data = await res.json();
      setFizzBuzzList(data);
    } catch (error) {
      console.error("API呼び出しに失敗しました:", error);
      setResult("API呼び出しに失敗しました");
    }
  };

  return (
    <div>
      <h1>FizzBuzz SPA</h1>
      <input
        type="number"
        value={start}
        onChange={(e) => setStart(parseInt(e.target.value))}
        placeholder="開始値"
      />
      <input
        type="number"
        value={end}
        onChange={(e) => setEnd(parseInt(e.target.value))}
        placeholder="終了値"
      />
      <button onClick={handleCheck}>判定</button>
      <ul>
        {fizzBuzzList.map((item, index) => (
          <li key={index}>{item}</li>
        ))}
      </ul>
    </div>
  );
}

export default App;
