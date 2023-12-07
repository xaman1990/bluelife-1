import { infoPersonaStore } from "../../stores/infoPersonaStore";
import { authenticationStore } from "../../stores/authenticationStore";

function ButtonBusqueda({ id, placeholder, dni }: buttonProps) {
  const { credentials } = authenticationStore();

  const { setInfoPersona } = infoPersonaStore();
  const busquedaDocumento = (dni: string, force: string, userexterno: string) =>
    setInfoPersona(dni, force, userexterno);

  return (
    <button
      id={id}
      className="btn btn-active btn-neutral"
      onClick={() => busquedaDocumento(dni, "1", credentials[0].value)}
    >
      <svg
        xmlns="http://www.w3.org/2000/svg"
        className="h-6 w-6"
        fill="none"
        viewBox="0 0 24 24"
        stroke="currentColor"
      >
        <path
          strokeLinecap="round"
          strokeLinejoin="round"
          strokeWidth="2"
          d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"
        />
      </svg>
      {placeholder}
    </button>
  );
}
interface buttonProps {
  id: string;
  placeholder: string;
  dni: string;
}

export default ButtonBusqueda;
