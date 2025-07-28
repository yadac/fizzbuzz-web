import React, { useState } from "react";

function App() {
  const [input, setInput] = useState<number>(1);
  const [result, setResult] = useState<string | null>(null);

  const handleCheck = async () => {
    // 仮にAPIがまだない場合はローカルロジックでもOK
    if (input % 15 === 0) setResult("FizzBuzz");
    else if (input % 3 === 0) setResult("Fizz");
    else if (input % 5 === 0) setResult("Buzz");
    else setResult(input.toString());
  };

  return (
    <div>
      <h1>FizzBuzz SPA</h1>
      <input
        type="number"
        value={input}
        onChange={(e) => setInput(parseInt(e.target.value))}
      />
      <button onClick={handleCheck}>判定</button>
      {result && (
        <p>
          結果: <strong>{result}</strong>
        </p>
      )}
    </div>
  );
}

export default App;
