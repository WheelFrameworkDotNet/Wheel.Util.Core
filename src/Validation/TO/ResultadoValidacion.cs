using Wheel.Util.Core.Editions.TO;

namespace Wheel.Util.Core.Validation.TO
{
    /// <summary>
    /// Entrega el resultado de la validación
    /// </summary>
    /// <remarks>
    ///    <para>
    ///         <h2 class="groupheader">Registro de versiones</h2>
    ///         <ul>
    ///             <li>1.0.0</li>
    ///             <table>
    ///                 <tr style="font-weight: bold;">
    ///                     <td>Autor</td>
    ///                     <td>Fecha</td>
    ///                     <td>Descripción</td>
    ///                 </tr>
    ///                 <tr>
    ///                     <td>Marcos Abraham Hernández Bravo.</td>
    ///                     <td>07/11/2016</td>
    ///                     <td>Versión Inicial.</td>
    ///                 </tr>
    ///             </table>
    ///         </ul>
    ///     </para>
    /// </remarks>
    /// <typeparam name="T">Tipo de valor que devuelve la cosa</typeparam>
    /// <typeparam name="E">Enumeración de errores</typeparam>
    public class ResultadoValidacion<T,E> : ResultadoEdicion<E>
    {
        /// <summary>
        /// Obtiene o establece el valor esperado de la validacion. Utilizado para realizar la persistencia.
        /// </summary>
        /// <remarks>
        ///    <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>07/11/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        public T Valor { get; set; }
    }
}
