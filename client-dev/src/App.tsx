import { useState, useEffect } from "react";
import "./App.css";

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    fetch("https://localhost:5001/api/activities")
      .then((response) => response.json())
      // .then((data) => setActivities(data));
      .then((data: Activity[]) => setActivities(data));

    return () => {
      // Cleanup function if needed
    };
  }, []);

  return (
    <>
      <section id="center">
        <div className="hero">MedActivities</div>
        <div>
          <h1>EgészségÚt</h1>
          <ul>
            {activities.map((activity) => (
              <li key={activity.id}>{activity.title}</li>
            ))}
          </ul>
        </div>
      </section>
    </>
  );
}

export default App;
