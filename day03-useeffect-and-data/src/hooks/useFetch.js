import { useState, useEffect } from "react";

function useFetch(url) {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    if (!url) return;

    const controller = new AbortController();

    const load = async () => {
      try {
        setLoading(true);
        setError(null);

        const res = await fetch(url, { signal: controller.signal });

        if (!res.ok) {
          throw new Error(`HTTP ${res.status}`);
        }

        const json = await res.json();
        setData(json);
      } catch (e) {
        if (e.name !== "AbortError") {
          setError(e.message);
        }
      } finally {
        setLoading(false);
      }
    };

    load();

    return () => {
      controller.abort();
    };
  }, [url]);

  return { data, loading, error };
}

export default useFetch;