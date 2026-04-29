using System;
using SysWork.Data.GenericDataManager;
using SysWork.Data.Common.ValueObjects;
using Test.Repositories;
using Test.ViewManagers;
namespace Test
{
	/// <summary>
	/// This class was created automatically with the DataManagerClassWriter.
	/// </summary>

	public partial class Db : BaseInstantiableDataManager
	{
		//Repositories
		private AUX_ANEXOARepository _aUX_ANEXOARepository;
		public AUX_ANEXOARepository AUX_ANEXOA {get => _aUX_ANEXOARepository;}

		private AUX_BALANCEGRALRepository _aUX_BALANCEGRALRepository;
		public AUX_BALANCEGRALRepository AUX_BALANCEGRAL {get => _aUX_BALANCEGRALRepository;}

		private AUX_EST_PRODRepository _aUX_EST_PRODRepository;
		public AUX_EST_PRODRepository AUX_EST_PROD {get => _aUX_EST_PRODRepository;}

		private AUX_EstadisticaCtaRepository _aUX_EstadisticaCtaRepository;
		public AUX_EstadisticaCtaRepository AUX_EstadisticaCta {get => _aUX_EstadisticaCtaRepository;}

		private AUX_MAYORESRepository _aUX_MAYORESRepository;
		public AUX_MAYORESRepository AUX_MAYORES {get => _aUX_MAYORESRepository;}

		private Aux_MV_CpteRepository _aux_MV_CpteRepository;
		public Aux_MV_CpteRepository Aux_MV_Cpte {get => _aux_MV_CpteRepository;}

		private Aux_MV_CpteQRRepository _aux_MV_CpteQRRepository;
		public Aux_MV_CpteQRRepository Aux_MV_CpteQR {get => _aux_MV_CpteQRRepository;}

		private AUX_SALDOSMENSUALESRepository _aUX_SALDOSMENSUALESRepository;
		public AUX_SALDOSMENSUALESRepository AUX_SALDOSMENSUALES {get => _aUX_SALDOSMENSUALESRepository;}

		private AUX_SUBDIARIOSRepository _aUX_SUBDIARIOSRepository;
		public AUX_SUBDIARIOSRepository AUX_SUBDIARIOS {get => _aUX_SUBDIARIOSRepository;}

		private AUX_TMPRepository _aUX_TMPRepository;
		public AUX_TMPRepository AUX_TMP {get => _aUX_TMPRepository;}

		private Aux_totalesRepository _aux_totalesRepository;
		public Aux_totalesRepository Aux_totales {get => _aux_totalesRepository;}

		private AUX_TOTALES_DETRepository _aUX_TOTALES_DETRepository;
		public AUX_TOTALES_DETRepository AUX_TOTALES_DET {get => _aUX_TOTALES_DETRepository;}

		private C_MV_CpteRepository _c_MV_CpteRepository;
		public C_MV_CpteRepository C_MV_Cpte {get => _c_MV_CpteRepository;}

		private C_MV_CPTE_OBSERVRepository _c_MV_CPTE_OBSERVRepository;
		public C_MV_CPTE_OBSERVRepository C_MV_CPTE_OBSERV {get => _c_MV_CPTE_OBSERVRepository;}

		private C_MV_CPTE_PERCEPCIONESRepository _c_MV_CPTE_PERCEPCIONESRepository;
		public C_MV_CPTE_PERCEPCIONESRepository C_MV_CPTE_PERCEPCIONES {get => _c_MV_CPTE_PERCEPCIONESRepository;}

		private C_MV_CpteInsumosRepository _c_MV_CpteInsumosRepository;
		public C_MV_CpteInsumosRepository C_MV_CpteInsumos {get => _c_MV_CpteInsumosRepository;}

		private C_MV_CpteTareasRepository _c_MV_CpteTareasRepository;
		public C_MV_CpteTareasRepository C_MV_CpteTareas {get => _c_MV_CpteTareasRepository;}

		private C_Proveedores_CCompraRepository _c_Proveedores_CCompraRepository;
		public C_Proveedores_CCompraRepository C_Proveedores_CCompra {get => _c_Proveedores_CCompraRepository;}

		private CONTROL_ACCESORepository _cONTROL_ACCESORepository;
		public CONTROL_ACCESORepository CONTROL_ACCESO {get => _cONTROL_ACCESORepository;}

		private Control_MV_CalculoRepository _control_MV_CalculoRepository;
		public Control_MV_CalculoRepository Control_MV_Calculo {get => _control_MV_CalculoRepository;}

		private CRM_MV_EVENTOSRepository _cRM_MV_EVENTOSRepository;
		public CRM_MV_EVENTOSRepository CRM_MV_EVENTOS {get => _cRM_MV_EVENTOSRepository;}

		private CRM_TA_EVENTOSRepository _cRM_TA_EVENTOSRepository;
		public CRM_TA_EVENTOSRepository CRM_TA_EVENTOS {get => _cRM_TA_EVENTOSRepository;}

		private dtpropertiesRepository _dtpropertiesRepository;
		public dtpropertiesRepository dtproperties {get => _dtpropertiesRepository;}

		private EM_MV_PESADAS_TRIGORepository _eM_MV_PESADAS_TRIGORepository;
		public EM_MV_PESADAS_TRIGORepository EM_MV_PESADAS_TRIGO {get => _eM_MV_PESADAS_TRIGORepository;}

		private EQ_COND_INTERFACESRepository _eQ_COND_INTERFACESRepository;
		public EQ_COND_INTERFACESRepository EQ_COND_INTERFACES {get => _eQ_COND_INTERFACESRepository;}

		private EQ_CONDIVA_IMPORTACIONRepository _eQ_CONDIVA_IMPORTACIONRepository;
		public EQ_CONDIVA_IMPORTACIONRepository EQ_CONDIVA_IMPORTACION {get => _eQ_CONDIVA_IMPORTACIONRepository;}

		private EQ_CTA_INTERFACERepository _eQ_CTA_INTERFACERepository;
		public EQ_CTA_INTERFACERepository EQ_CTA_INTERFACE {get => _eQ_CTA_INTERFACERepository;}

		private EQ_TC_INTERFACERepository _eQ_TC_INTERFACERepository;
		public EQ_TC_INTERFACERepository EQ_TC_INTERFACE {get => _eQ_TC_INTERFACERepository;}

		private GM_V_MV_PLANILLA_CABRepository _gM_V_MV_PLANILLA_CABRepository;
		public GM_V_MV_PLANILLA_CABRepository GM_V_MV_PLANILLA_CAB {get => _gM_V_MV_PLANILLA_CABRepository;}

		private GM_V_MV_PLANILLA_DETALLERepository _gM_V_MV_PLANILLA_DETALLERepository;
		public GM_V_MV_PLANILLA_DETALLERepository GM_V_MV_PLANILLA_DETALLE {get => _gM_V_MV_PLANILLA_DETALLERepository;}

		private L_MA_LicenciasRepository _l_MA_LicenciasRepository;
		public L_MA_LicenciasRepository L_MA_Licencias {get => _l_MA_LicenciasRepository;}

		private L_MA_LicenciasCategoriasRepository _l_MA_LicenciasCategoriasRepository;
		public L_MA_LicenciasCategoriasRepository L_MA_LicenciasCategorias {get => _l_MA_LicenciasCategoriasRepository;}

		private L_MA_LICENCIASCtrolMedicoRepository _l_MA_LICENCIASCtrolMedicoRepository;
		public L_MA_LICENCIASCtrolMedicoRepository L_MA_LICENCIASCtrolMedico {get => _l_MA_LICENCIASCtrolMedicoRepository;}

		private L_MA_LICENCIASDOCUMENTACIONRepository _l_MA_LICENCIASDOCUMENTACIONRepository;
		public L_MA_LICENCIASDOCUMENTACIONRepository L_MA_LICENCIASDOCUMENTACION {get => _l_MA_LICENCIASDOCUMENTACIONRepository;}

		private L_MA_LICENCIASEXAMENESRepository _l_MA_LICENCIASEXAMENESRepository;
		public L_MA_LICENCIASEXAMENESRepository L_MA_LICENCIASEXAMENES {get => _l_MA_LICENCIASEXAMENESRepository;}

		private L_MV_LicenciasRepository _l_MV_LicenciasRepository;
		public L_MV_LicenciasRepository L_MV_Licencias {get => _l_MV_LicenciasRepository;}

		private L_MV_RuitRepository _l_MV_RuitRepository;
		public L_MV_RuitRepository L_MV_Ruit {get => _l_MV_RuitRepository;}

		private L_TA_CategoriasRepository _l_TA_CategoriasRepository;
		public L_TA_CategoriasRepository L_TA_Categorias {get => _l_TA_CategoriasRepository;}

		private L_TA_ClaseLicenciaRepository _l_TA_ClaseLicenciaRepository;
		public L_TA_ClaseLicenciaRepository L_TA_ClaseLicencia {get => _l_TA_ClaseLicenciaRepository;}

		private L_TA_ControlMedicoRepository _l_TA_ControlMedicoRepository;
		public L_TA_ControlMedicoRepository L_TA_ControlMedico {get => _l_TA_ControlMedicoRepository;}

		private L_TA_DocumentacionRepository _l_TA_DocumentacionRepository;
		public L_TA_DocumentacionRepository L_TA_Documentacion {get => _l_TA_DocumentacionRepository;}

		private L_TA_ExamenesRepository _l_TA_ExamenesRepository;
		public L_TA_ExamenesRepository L_TA_Examenes {get => _l_TA_ExamenesRepository;}

		private L_TA_LocalidadesRepository _l_TA_LocalidadesRepository;
		public L_TA_LocalidadesRepository L_TA_Localidades {get => _l_TA_LocalidadesRepository;}

		private L_TA_PartidosRepository _l_TA_PartidosRepository;
		public L_TA_PartidosRepository L_TA_Partidos {get => _l_TA_PartidosRepository;}

		private L_TA_TipoDocRepository _l_TA_TipoDocRepository;
		public L_TA_TipoDocRepository L_TA_TipoDoc {get => _l_TA_TipoDocRepository;}

		private LogDbRepository _logDbRepository;
		public LogDbRepository LogDb {get => _logDbRepository;}

		private MA_ARBOL_OPERATIVORepository _mA_ARBOL_OPERATIVORepository;
		public MA_ARBOL_OPERATIVORepository MA_ARBOL_OPERATIVO {get => _mA_ARBOL_OPERATIVORepository;}

		private MA_BIENESRepository _mA_BIENESRepository;
		public MA_BIENESRepository MA_BIENES {get => _mA_BIENESRepository;}

		private MA_BIENES_NOVEDADESRepository _mA_BIENES_NOVEDADESRepository;
		public MA_BIENES_NOVEDADESRepository MA_BIENES_NOVEDADES {get => _mA_BIENES_NOVEDADESRepository;}

		private MA_CalendarioRepository _mA_CalendarioRepository;
		public MA_CalendarioRepository MA_Calendario {get => _mA_CalendarioRepository;}

		private MA_CASH_CONTROLRepository _mA_CASH_CONTROLRepository;
		public MA_CASH_CONTROLRepository MA_CASH_CONTROL {get => _mA_CASH_CONTROLRepository;}

		private MA_CASH_CTAS_PRINCIPALESRepository _mA_CASH_CTAS_PRINCIPALESRepository;
		public MA_CASH_CTAS_PRINCIPALESRepository MA_CASH_CTAS_PRINCIPALES {get => _mA_CASH_CTAS_PRINCIPALESRepository;}

		private MA_CASH_DETALLERepository _mA_CASH_DETALLERepository;
		public MA_CASH_DETALLERepository MA_CASH_DETALLE {get => _mA_CASH_DETALLERepository;}

		private MA_CASH_FLOWRepository _mA_CASH_FLOWRepository;
		public MA_CASH_FLOWRepository MA_CASH_FLOW {get => _mA_CASH_FLOWRepository;}

		private MA_CASH_GRUPORepository _mA_CASH_GRUPORepository;
		public MA_CASH_GRUPORepository MA_CASH_GRUPO {get => _mA_CASH_GRUPORepository;}

		private MA_CASH_PROYECTADORepository _mA_CASH_PROYECTADORepository;
		public MA_CASH_PROYECTADORepository MA_CASH_PROYECTADO {get => _mA_CASH_PROYECTADORepository;}

		private MA_CASHPFERepository _mA_CASHPFERepository;
		public MA_CASHPFERepository MA_CASHPFE {get => _mA_CASHPFERepository;}

		private MA_CASHPFE_DETALLERepository _mA_CASHPFE_DETALLERepository;
		public MA_CASHPFE_DETALLERepository MA_CASHPFE_DETALLE {get => _mA_CASHPFE_DETALLERepository;}

		private MA_CASHPFE_GRUPORepository _mA_CASHPFE_GRUPORepository;
		public MA_CASHPFE_GRUPORepository MA_CASHPFE_GRUPO {get => _mA_CASHPFE_GRUPORepository;}

		private MA_CASHPFE_PROYECTADORepository _mA_CASHPFE_PROYECTADORepository;
		public MA_CASHPFE_PROYECTADORepository MA_CASHPFE_PROYECTADO {get => _mA_CASHPFE_PROYECTADORepository;}

		private MA_ChoferesRepository _mA_ChoferesRepository;
		public MA_ChoferesRepository MA_Choferes {get => _mA_ChoferesRepository;}

		private MA_CONTACTOSRepository _mA_CONTACTOSRepository;
		public MA_CONTACTOSRepository MA_CONTACTOS {get => _mA_CONTACTOSRepository;}

		private MA_CONTACTOS_ADICRepository _mA_CONTACTOS_ADICRepository;
		public MA_CONTACTOS_ADICRepository MA_CONTACTOS_ADIC {get => _mA_CONTACTOS_ADICRepository;}

		private MA_CUENTASRepository _mA_CUENTASRepository;
		public MA_CUENTASRepository MA_CUENTAS {get => _mA_CUENTASRepository;}

		private MA_CUENTAS_ALERTASRepository _mA_CUENTAS_ALERTASRepository;
		public MA_CUENTAS_ALERTASRepository MA_CUENTAS_ALERTAS {get => _mA_CUENTAS_ALERTASRepository;}

		private MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository _mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository;
		public MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository MA_CUENTAS_ARCHIVOS_RELACIONADOS {get => _mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository;}

		private MA_CUENTAS_CTAS_BANCARIASRepository _mA_CUENTAS_CTAS_BANCARIASRepository;
		public MA_CUENTAS_CTAS_BANCARIASRepository MA_CUENTAS_CTAS_BANCARIAS {get => _mA_CUENTAS_CTAS_BANCARIASRepository;}

		private MA_CUENTAS_DATOS_LABORALESRepository _mA_CUENTAS_DATOS_LABORALESRepository;
		public MA_CUENTAS_DATOS_LABORALESRepository MA_CUENTAS_DATOS_LABORALES {get => _mA_CUENTAS_DATOS_LABORALESRepository;}

		private MA_CUENTAS_DESCUENTO_RUBROSRepository _mA_CUENTAS_DESCUENTO_RUBROSRepository;
		public MA_CUENTAS_DESCUENTO_RUBROSRepository MA_CUENTAS_DESCUENTO_RUBROS {get => _mA_CUENTAS_DESCUENTO_RUBROSRepository;}

		private MA_CUENTAS_DIRECCIONESRepository _mA_CUENTAS_DIRECCIONESRepository;
		public MA_CUENTAS_DIRECCIONESRepository MA_CUENTAS_DIRECCIONES {get => _mA_CUENTAS_DIRECCIONESRepository;}

		private MA_CUENTAS_ENCOMIENDASRepository _mA_CUENTAS_ENCOMIENDASRepository;
		public MA_CUENTAS_ENCOMIENDASRepository MA_CUENTAS_ENCOMIENDAS {get => _mA_CUENTAS_ENCOMIENDASRepository;}

		private MA_CUENTAS_ENCOMIENDAS_CANTRepository _mA_CUENTAS_ENCOMIENDAS_CANTRepository;
		public MA_CUENTAS_ENCOMIENDAS_CANTRepository MA_CUENTAS_ENCOMIENDAS_CANT {get => _mA_CUENTAS_ENCOMIENDAS_CANTRepository;}

		private MA_CUENTAS_FACTURACION_RECURRENTERepository _mA_CUENTAS_FACTURACION_RECURRENTERepository;
		public MA_CUENTAS_FACTURACION_RECURRENTERepository MA_CUENTAS_FACTURACION_RECURRENTE {get => _mA_CUENTAS_FACTURACION_RECURRENTERepository;}

		private MA_CUENTAS_FAMILIASRepository _mA_CUENTAS_FAMILIASRepository;
		public MA_CUENTAS_FAMILIASRepository MA_CUENTAS_FAMILIAS {get => _mA_CUENTAS_FAMILIASRepository;}

		private MA_CUENTAS_INFO_ADICIONALRepository _mA_CUENTAS_INFO_ADICIONALRepository;
		public MA_CUENTAS_INFO_ADICIONALRepository MA_CUENTAS_INFO_ADICIONAL {get => _mA_CUENTAS_INFO_ADICIONALRepository;}

		private MA_CUENTAS_INFORMESRepository _mA_CUENTAS_INFORMESRepository;
		public MA_CUENTAS_INFORMESRepository MA_CUENTAS_INFORMES {get => _mA_CUENTAS_INFORMESRepository;}

		private MA_CUENTAS_RUTEO_VENDEDORRepository _mA_CUENTAS_RUTEO_VENDEDORRepository;
		public MA_CUENTAS_RUTEO_VENDEDORRepository MA_CUENTAS_RUTEO_VENDEDOR {get => _mA_CUENTAS_RUTEO_VENDEDORRepository;}

		private MA_CUENTAS_SUCURSALESRepository _mA_CUENTAS_SUCURSALESRepository;
		public MA_CUENTAS_SUCURSALESRepository MA_CUENTAS_SUCURSALES {get => _mA_CUENTAS_SUCURSALESRepository;}

		private MA_CUENTAS_USUARIOSRepository _mA_CUENTAS_USUARIOSRepository;
		public MA_CUENTAS_USUARIOSRepository MA_CUENTAS_USUARIOS {get => _mA_CUENTAS_USUARIOSRepository;}

		private MA_CUENTASADICRepository _mA_CUENTASADICRepository;
		public MA_CUENTASADICRepository MA_CUENTASADIC {get => _mA_CUENTASADICRepository;}

		private MA_CUENTASCCOSTORepository _mA_CUENTASCCOSTORepository;
		public MA_CUENTASCCOSTORepository MA_CUENTASCCOSTO {get => _mA_CUENTASCCOSTORepository;}

		private MA_ESTADISTICACTARepository _mA_ESTADISTICACTARepository;
		public MA_ESTADISTICACTARepository MA_ESTADISTICACTA {get => _mA_ESTADISTICACTARepository;}

		private MA_INDAJUSTERepository _mA_INDAJUSTERepository;
		public MA_INDAJUSTERepository MA_INDAJUSTE {get => _mA_INDAJUSTERepository;}

		private MA_MODELOSRepository _mA_MODELOSRepository;
		public MA_MODELOSRepository MA_MODELOS {get => _mA_MODELOSRepository;}

		private MA_SUBDIARIOSRepository _mA_SUBDIARIOSRepository;
		public MA_SUBDIARIOSRepository MA_SUBDIARIOS {get => _mA_SUBDIARIOSRepository;}

		private MA_SUBDIARIOSCOMPROBANTESRepository _mA_SUBDIARIOSCOMPROBANTESRepository;
		public MA_SUBDIARIOSCOMPROBANTESRepository MA_SUBDIARIOSCOMPROBANTES {get => _mA_SUBDIARIOSCOMPROBANTESRepository;}

		private MA_vehiculosRepository _mA_vehiculosRepository;
		public MA_vehiculosRepository MA_vehiculos {get => _mA_vehiculosRepository;}

		private MV_AgendaRepository _mV_AgendaRepository;
		public MV_AgendaRepository MV_Agenda {get => _mV_AgendaRepository;}

		private MV_APLICACIONRepository _mV_APLICACIONRepository;
		public MV_APLICACIONRepository MV_APLICACION {get => _mV_APLICACIONRepository;}

		private MV_ASIENTOSRepository _mV_ASIENTOSRepository;
		public MV_ASIENTOSRepository MV_ASIENTOS {get => _mV_ASIENTOSRepository;}

		private MV_ASIENTOSCCOSTORepository _mV_ASIENTOSCCOSTORepository;
		public MV_ASIENTOSCCOSTORepository MV_ASIENTOSCCOSTO {get => _mV_ASIENTOSCCOSTORepository;}

		private MV_BIENESRepository _mV_BIENESRepository;
		public MV_BIENESRepository MV_BIENES {get => _mV_BIENESRepository;}

		private MV_BIENES_DETALLERepository _mV_BIENES_DETALLERepository;
		public MV_BIENES_DETALLERepository MV_BIENES_DETALLE {get => _mV_BIENES_DETALLERepository;}

		private MV_CALCULO_BIENESRepository _mV_CALCULO_BIENESRepository;
		public MV_CALCULO_BIENESRepository MV_CALCULO_BIENES {get => _mV_CALCULO_BIENESRepository;}

		private MV_CONTROL_AS_RESRepository _mV_CONTROL_AS_RESRepository;
		public MV_CONTROL_AS_RESRepository MV_CONTROL_AS_RES {get => _mV_CONTROL_AS_RESRepository;}

		private MV_EJERCICIOSRepository _mV_EJERCICIOSRepository;
		public MV_EJERCICIOSRepository MV_EJERCICIOS {get => _mV_EJERCICIOSRepository;}

		private MV_INVENTARIOSRepository _mV_INVENTARIOSRepository;
		public MV_INVENTARIOSRepository MV_INVENTARIOS {get => _mV_INVENTARIOSRepository;}

		private MV_INVENTARIOSCABRepository _mV_INVENTARIOSCABRepository;
		public MV_INVENTARIOSCABRepository MV_INVENTARIOSCAB {get => _mV_INVENTARIOSCABRepository;}

		private MV_SALDOSRepository _mV_SALDOSRepository;
		public MV_SALDOSRepository MV_SALDOS {get => _mV_SALDOSRepository;}

		private P_MA_ClientesRepository _p_MA_ClientesRepository;
		public P_MA_ClientesRepository P_MA_Clientes {get => _p_MA_ClientesRepository;}

		private P_MA_EmpresasRepository _p_MA_EmpresasRepository;
		public P_MA_EmpresasRepository P_MA_Empresas {get => _p_MA_EmpresasRepository;}

		private P_MA_FamiliarRepository _p_MA_FamiliarRepository;
		public P_MA_FamiliarRepository P_MA_Familiar {get => _p_MA_FamiliarRepository;}

		private P_MA_LegajosRepository _p_MA_LegajosRepository;
		public P_MA_LegajosRepository P_MA_Legajos {get => _p_MA_LegajosRepository;}

		private P_MA_PostulanteAuxiliarRepository _p_MA_PostulanteAuxiliarRepository;
		public P_MA_PostulanteAuxiliarRepository P_MA_PostulanteAuxiliar {get => _p_MA_PostulanteAuxiliarRepository;}

		private P_MA_PostulantesRepository _p_MA_PostulantesRepository;
		public P_MA_PostulantesRepository P_MA_Postulantes {get => _p_MA_PostulantesRepository;}

		private P_MA_Postulantes_ConocimientosRepository _p_MA_Postulantes_ConocimientosRepository;
		public P_MA_Postulantes_ConocimientosRepository P_MA_Postulantes_Conocimientos {get => _p_MA_Postulantes_ConocimientosRepository;}

		private P_MA_Postulantes_ExperienciaRepository _p_MA_Postulantes_ExperienciaRepository;
		public P_MA_Postulantes_ExperienciaRepository P_MA_Postulantes_Experiencia {get => _p_MA_Postulantes_ExperienciaRepository;}

		private P_MA_Postulantes_IdiomasRepository _p_MA_Postulantes_IdiomasRepository;
		public P_MA_Postulantes_IdiomasRepository P_MA_Postulantes_Idiomas {get => _p_MA_Postulantes_IdiomasRepository;}

		private P_MA_Postulantes_ObsRepository _p_MA_Postulantes_ObsRepository;
		public P_MA_Postulantes_ObsRepository P_MA_Postulantes_Obs {get => _p_MA_Postulantes_ObsRepository;}

		private P_MA_Postulantes_TitulosRepository _p_MA_Postulantes_TitulosRepository;
		public P_MA_Postulantes_TitulosRepository P_MA_Postulantes_Titulos {get => _p_MA_Postulantes_TitulosRepository;}

		private P_MV_BusquedasRepository _p_MV_BusquedasRepository;
		public P_MV_BusquedasRepository P_MV_Busquedas {get => _p_MV_BusquedasRepository;}

		private P_MV_CtrolHorariosRepository _p_MV_CtrolHorariosRepository;
		public P_MV_CtrolHorariosRepository P_MV_CtrolHorarios {get => _p_MV_CtrolHorariosRepository;}

		private P_MV_DeudoresRepository _p_MV_DeudoresRepository;
		public P_MV_DeudoresRepository P_MV_Deudores {get => _p_MV_DeudoresRepository;}

		private P_MV_EntrevistasRepository _p_MV_EntrevistasRepository;
		public P_MV_EntrevistasRepository P_MV_Entrevistas {get => _p_MV_EntrevistasRepository;}

		private P_MV_ReferenciasRepository _p_MV_ReferenciasRepository;
		public P_MV_ReferenciasRepository P_MV_Referencias {get => _p_MV_ReferenciasRepository;}

		private P_MV_SeguimientoRepository _p_MV_SeguimientoRepository;
		public P_MV_SeguimientoRepository P_MV_Seguimiento {get => _p_MV_SeguimientoRepository;}

		private P_MV_SolicitudRRHHRepository _p_MV_SolicitudRRHHRepository;
		public P_MV_SolicitudRRHHRepository P_MV_SolicitudRRHH {get => _p_MV_SolicitudRRHHRepository;}

		private P_MV_SolicitudRRHH_ConocimientosRepository _p_MV_SolicitudRRHH_ConocimientosRepository;
		public P_MV_SolicitudRRHH_ConocimientosRepository P_MV_SolicitudRRHH_Conocimientos {get => _p_MV_SolicitudRRHH_ConocimientosRepository;}

		private P_MV_SolicitudRRHH_IdiomasRepository _p_MV_SolicitudRRHH_IdiomasRepository;
		public P_MV_SolicitudRRHH_IdiomasRepository P_MV_SolicitudRRHH_Idiomas {get => _p_MV_SolicitudRRHH_IdiomasRepository;}

		private P_MV_SolicitudRRHH_TitulosRepository _p_MV_SolicitudRRHH_TitulosRepository;
		public P_MV_SolicitudRRHH_TitulosRepository P_MV_SolicitudRRHH_Titulos {get => _p_MV_SolicitudRRHH_TitulosRepository;}

		private P_TA_AreasRepository _p_TA_AreasRepository;
		public P_TA_AreasRepository P_TA_Areas {get => _p_TA_AreasRepository;}

		private P_TA_CategorizacionRepository _p_TA_CategorizacionRepository;
		public P_TA_CategorizacionRepository P_TA_Categorizacion {get => _p_TA_CategorizacionRepository;}

		private P_TA_CentroMedicoRepository _p_TA_CentroMedicoRepository;
		public P_TA_CentroMedicoRepository P_TA_CentroMedico {get => _p_TA_CentroMedicoRepository;}

		private P_Ta_ConocimientosRepository _p_Ta_ConocimientosRepository;
		public P_Ta_ConocimientosRepository P_Ta_Conocimientos {get => _p_Ta_ConocimientosRepository;}

		private P_TA_EstadoBusquedaRepository _p_TA_EstadoBusquedaRepository;
		public P_TA_EstadoBusquedaRepository P_TA_EstadoBusqueda {get => _p_TA_EstadoBusquedaRepository;}

		private P_TA_EstadoCivilRepository _p_TA_EstadoCivilRepository;
		public P_TA_EstadoCivilRepository P_TA_EstadoCivil {get => _p_TA_EstadoCivilRepository;}

		private P_TA_EstadoPostulanteRepository _p_TA_EstadoPostulanteRepository;
		public P_TA_EstadoPostulanteRepository P_TA_EstadoPostulante {get => _p_TA_EstadoPostulanteRepository;}

		private P_TA_FormasDePagoRepository _p_TA_FormasDePagoRepository;
		public P_TA_FormasDePagoRepository P_TA_FormasDePago {get => _p_TA_FormasDePagoRepository;}

		private P_TA_FuncionesRepository _p_TA_FuncionesRepository;
		public P_TA_FuncionesRepository P_TA_Funciones {get => _p_TA_FuncionesRepository;}

		private P_TA_GruposRepository _p_TA_GruposRepository;
		public P_TA_GruposRepository P_TA_Grupos {get => _p_TA_GruposRepository;}

		private P_TA_IdiomasRepository _p_TA_IdiomasRepository;
		public P_TA_IdiomasRepository P_TA_Idiomas {get => _p_TA_IdiomasRepository;}

		private P_TA_MotivoEgresoRepository _p_TA_MotivoEgresoRepository;
		public P_TA_MotivoEgresoRepository P_TA_MotivoEgreso {get => _p_TA_MotivoEgresoRepository;}

		private P_TA_NivelEstudioRepository _p_TA_NivelEstudioRepository;
		public P_TA_NivelEstudioRepository P_TA_NivelEstudio {get => _p_TA_NivelEstudioRepository;}

		private P_TA_ObraSocialRepository _p_TA_ObraSocialRepository;
		public P_TA_ObraSocialRepository P_TA_ObraSocial {get => _p_TA_ObraSocialRepository;}

		private P_TA_ParentescoRepository _p_TA_ParentescoRepository;
		public P_TA_ParentescoRepository P_TA_Parentesco {get => _p_TA_ParentescoRepository;}

		private P_TA_SindicatosRepository _p_TA_SindicatosRepository;
		public P_TA_SindicatosRepository P_TA_Sindicatos {get => _p_TA_SindicatosRepository;}

		private P_TA_TipoPuestoRepository _p_TA_TipoPuestoRepository;
		public P_TA_TipoPuestoRepository P_TA_TipoPuesto {get => _p_TA_TipoPuestoRepository;}

		private P_TA_TitulosRepository _p_TA_TitulosRepository;
		public P_TA_TitulosRepository P_TA_Titulos {get => _p_TA_TitulosRepository;}

		private P_TA_ZonaResidenciaRepository _p_TA_ZonaResidenciaRepository;
		public P_TA_ZonaResidenciaRepository P_TA_ZonaResidencia {get => _p_TA_ZonaResidenciaRepository;}

		private PRUEBAESTADISTICARepository _pRUEBAESTADISTICARepository;
		public PRUEBAESTADISTICARepository PRUEBAESTADISTICA {get => _pRUEBAESTADISTICARepository;}

		private RMA_ESTADOSRepository _rMA_ESTADOSRepository;
		public RMA_ESTADOSRepository RMA_ESTADOS {get => _rMA_ESTADOSRepository;}

		private RMA_MOTIVOSRepository _rMA_MOTIVOSRepository;
		public RMA_MOTIVOSRepository RMA_MOTIVOS {get => _rMA_MOTIVOSRepository;}

		private RMA_TRAZABILIDAD_ARTICULOSRepository _rMA_TRAZABILIDAD_ARTICULOSRepository;
		public RMA_TRAZABILIDAD_ARTICULOSRepository RMA_TRAZABILIDAD_ARTICULOS {get => _rMA_TRAZABILIDAD_ARTICULOSRepository;}

		private S_TA_EQUIVRepository _s_TA_EQUIVRepository;
		public S_TA_EQUIVRepository S_TA_EQUIV {get => _s_TA_EQUIVRepository;}

		private T_VEHICULOS_NOVEDADESRepository _t_VEHICULOS_NOVEDADESRepository;
		public T_VEHICULOS_NOVEDADESRepository T_VEHICULOS_NOVEDADES {get => _t_VEHICULOS_NOVEDADESRepository;}

		private TA_AGRUPCUENTASRepository _tA_AGRUPCUENTASRepository;
		public TA_AGRUPCUENTASRepository TA_AGRUPCUENTAS {get => _tA_AGRUPCUENTASRepository;}

		private TA_AGRUPCUENTAS_DETALLERepository _tA_AGRUPCUENTAS_DETALLERepository;
		public TA_AGRUPCUENTAS_DETALLERepository TA_AGRUPCUENTAS_DETALLE {get => _tA_AGRUPCUENTAS_DETALLERepository;}

		private Ta_ArchivoLegalRepository _ta_ArchivoLegalRepository;
		public Ta_ArchivoLegalRepository Ta_ArchivoLegal {get => _ta_ArchivoLegalRepository;}

		private TA_AUDITORIARepository _tA_AUDITORIARepository;
		public TA_AUDITORIARepository TA_AUDITORIA {get => _tA_AUDITORIARepository;}

		private TA_BIENES_CCOSTORepository _tA_BIENES_CCOSTORepository;
		public TA_BIENES_CCOSTORepository TA_BIENES_CCOSTO {get => _tA_BIENES_CCOSTORepository;}

		private TA_BIENES_CLASESRepository _tA_BIENES_CLASESRepository;
		public TA_BIENES_CLASESRepository TA_BIENES_CLASES {get => _tA_BIENES_CLASESRepository;}

		private TA_BIENES_ESTADOSRepository _tA_BIENES_ESTADOSRepository;
		public TA_BIENES_ESTADOSRepository TA_BIENES_ESTADOS {get => _tA_BIENES_ESTADOSRepository;}

		private TA_BIENES_MARCASRepository _tA_BIENES_MARCASRepository;
		public TA_BIENES_MARCASRepository TA_BIENES_MARCAS {get => _tA_BIENES_MARCASRepository;}

		private TA_BIENES_MOTIVOSRepository _tA_BIENES_MOTIVOSRepository;
		public TA_BIENES_MOTIVOSRepository TA_BIENES_MOTIVOS {get => _tA_BIENES_MOTIVOSRepository;}

		private TA_BIENES_PROPIETARIOSRepository _tA_BIENES_PROPIETARIOSRepository;
		public TA_BIENES_PROPIETARIOSRepository TA_BIENES_PROPIETARIOS {get => _tA_BIENES_PROPIETARIOSRepository;}

		private TA_BIENES_TIPOSRepository _tA_BIENES_TIPOSRepository;
		public TA_BIENES_TIPOSRepository TA_BIENES_TIPOS {get => _tA_BIENES_TIPOSRepository;}

		private TA_CCOSTORepository _tA_CCOSTORepository;
		public TA_CCOSTORepository TA_CCOSTO {get => _tA_CCOSTORepository;}

		private TA_COMPROBANTESRepository _tA_COMPROBANTESRepository;
		public TA_COMPROBANTESRepository TA_COMPROBANTES {get => _tA_COMPROBANTESRepository;}

		private TA_CONDIVARepository _tA_CONDIVARepository;
		public TA_CONDIVARepository TA_CONDIVA {get => _tA_CONDIVARepository;}

		private TA_CONFIGURACIONRepository _tA_CONFIGURACIONRepository;
		public TA_CONFIGURACIONRepository TA_CONFIGURACION {get => _tA_CONFIGURACIONRepository;}

		private TA_COTIZACIONRepository _tA_COTIZACIONRepository;
		public TA_COTIZACIONRepository TA_COTIZACION {get => _tA_COTIZACIONRepository;}

		private TA_CUENTAS_COMPROBANTESRepository _tA_CUENTAS_COMPROBANTESRepository;
		public TA_CUENTAS_COMPROBANTESRepository TA_CUENTAS_COMPROBANTES {get => _tA_CUENTAS_COMPROBANTESRepository;}

		private TA_CUENTASIVARepository _tA_CUENTASIVARepository;
		public TA_CUENTASIVARepository TA_CUENTASIVA {get => _tA_CUENTASIVARepository;}

		private TA_DistLocalidadesRepository _tA_DistLocalidadesRepository;
		public TA_DistLocalidadesRepository TA_DistLocalidades {get => _tA_DistLocalidadesRepository;}

		private TA_ESTADOSRepository _tA_ESTADOSRepository;
		public TA_ESTADOSRepository TA_ESTADOS {get => _tA_ESTADOSRepository;}

		private TA_IMPORTACUENTASRepository _tA_IMPORTACUENTASRepository;
		public TA_IMPORTACUENTASRepository TA_IMPORTACUENTAS {get => _tA_IMPORTACUENTASRepository;}

		private TA_IMPORTACUENTASDETALLERepository _tA_IMPORTACUENTASDETALLERepository;
		public TA_IMPORTACUENTASDETALLERepository TA_IMPORTACUENTASDETALLE {get => _tA_IMPORTACUENTASDETALLERepository;}

		private TA_INTERFACESRepository _tA_INTERFACESRepository;
		public TA_INTERFACESRepository TA_INTERFACES {get => _tA_INTERFACESRepository;}

		private TA_INTERFACES_DETALLERepository _tA_INTERFACES_DETALLERepository;
		public TA_INTERFACES_DETALLERepository TA_INTERFACES_DETALLE {get => _tA_INTERFACES_DETALLERepository;}

		private TA_LOGOSRepository _tA_LOGOSRepository;
		public TA_LOGOSRepository TA_LOGOS {get => _tA_LOGOSRepository;}

		private TA_MARCASRepository _tA_MARCASRepository;
		public TA_MARCASRepository TA_MARCAS {get => _tA_MARCASRepository;}

		private TA_MENURepository _tA_MENURepository;
		public TA_MENURepository TA_MENU {get => _tA_MENURepository;}

		private TA_MONEDASRepository _tA_MONEDASRepository;
		public TA_MONEDASRepository TA_MONEDAS {get => _tA_MONEDASRepository;}

		private Ta_NumArchivoLegalRepository _ta_NumArchivoLegalRepository;
		public Ta_NumArchivoLegalRepository Ta_NumArchivoLegal {get => _ta_NumArchivoLegalRepository;}

		private TA_PAISESRepository _tA_PAISESRepository;
		public TA_PAISESRepository TA_PAISES {get => _tA_PAISESRepository;}

		private TA_PUBLICACIONESRepository _tA_PUBLICACIONESRepository;
		public TA_PUBLICACIONESRepository TA_PUBLICACIONES {get => _tA_PUBLICACIONESRepository;}

		private TA_RANGOS_DATOS_ADICRepository _tA_RANGOS_DATOS_ADICRepository;
		public TA_RANGOS_DATOS_ADICRepository TA_RANGOS_DATOS_ADIC {get => _tA_RANGOS_DATOS_ADICRepository;}

		private TA_REPORTESRepository _tA_REPORTESRepository;
		public TA_REPORTESRepository TA_REPORTES {get => _tA_REPORTESRepository;}

		private TA_TAREASRepository _tA_TAREASRepository;
		public TA_TAREASRepository TA_TAREAS {get => _tA_TAREASRepository;}

		private TA_TERMINALESRepository _tA_TERMINALESRepository;
		public TA_TERMINALESRepository TA_TERMINALES {get => _tA_TERMINALESRepository;}

		private TA_TIPODOCUMENTORepository _tA_TIPODOCUMENTORepository;
		public TA_TIPODOCUMENTORepository TA_TIPODOCUMENTO {get => _tA_TIPODOCUMENTORepository;}

		private TA_TIPOVEHICULORepository _tA_TIPOVEHICULORepository;
		public TA_TIPOVEHICULORepository TA_TIPOVEHICULO {get => _tA_TIPOVEHICULORepository;}

		private TA_TITCOPIADORESRepository _tA_TITCOPIADORESRepository;
		public TA_TITCOPIADORESRepository TA_TITCOPIADORES {get => _tA_TITCOPIADORESRepository;}

		private TA_USUARIOSRepository _tA_USUARIOSRepository;
		public TA_USUARIOSRepository TA_USUARIOS {get => _tA_USUARIOSRepository;}

		private TA_VISTASRepository _tA_VISTASRepository;
		public TA_VISTASRepository TA_VISTAS {get => _tA_VISTASRepository;}

		private TESTIGO_EXPORTACIONRepository _tESTIGO_EXPORTACIONRepository;
		public TESTIGO_EXPORTACIONRepository TESTIGO_EXPORTACION {get => _tESTIGO_EXPORTACIONRepository;}

		private TESTIGO_RECEPCIONRepository _tESTIGO_RECEPCIONRepository;
		public TESTIGO_RECEPCIONRepository TESTIGO_RECEPCION {get => _tESTIGO_RECEPCIONRepository;}

		private TMP_BusquedaPrecioRepository _tMP_BusquedaPrecioRepository;
		public TMP_BusquedaPrecioRepository TMP_BusquedaPrecio {get => _tMP_BusquedaPrecioRepository;}

		private UTL_TA_VENTANASRepository _uTL_TA_VENTANASRepository;
		public UTL_TA_VENTANASRepository UTL_TA_VENTANAS {get => _uTL_TA_VENTANASRepository;}

		private V_CRM_MV_CPTERepository _v_CRM_MV_CPTERepository;
		public V_CRM_MV_CPTERepository V_CRM_MV_CPTE {get => _v_CRM_MV_CPTERepository;}

		private V_CRM_TA_ACCIONESRepository _v_CRM_TA_ACCIONESRepository;
		public V_CRM_TA_ACCIONESRepository V_CRM_TA_ACCIONES {get => _v_CRM_TA_ACCIONESRepository;}

		private V_CRM_TA_ESTADOSRepository _v_CRM_TA_ESTADOSRepository;
		public V_CRM_TA_ESTADOSRepository V_CRM_TA_ESTADOS {get => _v_CRM_TA_ESTADOSRepository;}

		private V_FIDELIZACIONRepository _v_FIDELIZACIONRepository;
		public V_FIDELIZACIONRepository V_FIDELIZACION {get => _v_FIDELIZACIONRepository;}

		private V_FIDELIZACION_ARTICULOSRepository _v_FIDELIZACION_ARTICULOSRepository;
		public V_FIDELIZACION_ARTICULOSRepository V_FIDELIZACION_ARTICULOS {get => _v_FIDELIZACION_ARTICULOSRepository;}

		private V_FIDELIZACION_MV_PUNTOSRepository _v_FIDELIZACION_MV_PUNTOSRepository;
		public V_FIDELIZACION_MV_PUNTOSRepository V_FIDELIZACION_MV_PUNTOS {get => _v_FIDELIZACION_MV_PUNTOSRepository;}

		private V_MA_AERONAVESRepository _v_MA_AERONAVESRepository;
		public V_MA_AERONAVESRepository V_MA_AERONAVES {get => _v_MA_AERONAVESRepository;}

		private V_MA_AERONAVES_COMPONENTESRepository _v_MA_AERONAVES_COMPONENTESRepository;
		public V_MA_AERONAVES_COMPONENTESRepository V_MA_AERONAVES_COMPONENTES {get => _v_MA_AERONAVES_COMPONENTESRepository;}

		private V_MA_AERONAVES_DOCUMENTOSRepository _v_MA_AERONAVES_DOCUMENTOSRepository;
		public V_MA_AERONAVES_DOCUMENTOSRepository V_MA_AERONAVES_DOCUMENTOS {get => _v_MA_AERONAVES_DOCUMENTOSRepository;}

		private V_MA_ARTICULOSRepository _v_MA_ARTICULOSRepository;
		public V_MA_ARTICULOSRepository V_MA_ARTICULOS {get => _v_MA_ARTICULOSRepository;}

		private V_MA_ARTICULOS_ALERTASRepository _v_MA_ARTICULOS_ALERTASRepository;
		public V_MA_ARTICULOS_ALERTASRepository V_MA_ARTICULOS_ALERTAS {get => _v_MA_ARTICULOS_ALERTASRepository;}

		private V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository _v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository;
		public V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOS {get => _v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository;}

		private V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository _v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository;
		public V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository V_MA_ARTICULOS_PROCESOS_PRODUCTIVOS {get => _v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository;}

		private V_MA_ARTICULOS_SINONIMOSRepository _v_MA_ARTICULOS_SINONIMOSRepository;
		public V_MA_ARTICULOS_SINONIMOSRepository V_MA_ARTICULOS_SINONIMOS {get => _v_MA_ARTICULOS_SINONIMOSRepository;}

		private V_MA_EXPRESOSRepository _v_MA_EXPRESOSRepository;
		public V_MA_EXPRESOSRepository V_MA_EXPRESOS {get => _v_MA_EXPRESOSRepository;}

		private V_MA_INSUMOSRepository _v_MA_INSUMOSRepository;
		public V_MA_INSUMOSRepository V_MA_INSUMOS {get => _v_MA_INSUMOSRepository;}

		private V_MA_POSICRepository _v_MA_POSICRepository;
		public V_MA_POSICRepository V_MA_POSIC {get => _v_MA_POSICRepository;}

		private V_MA_PreciosRepository _v_MA_PreciosRepository;
		public V_MA_PreciosRepository V_MA_Precios {get => _v_MA_PreciosRepository;}

		private V_MV_CpteRepository _v_MV_CpteRepository;
		public V_MV_CpteRepository V_MV_Cpte {get => _v_MV_CpteRepository;}

		private V_MV_CPTE_OBSERVRepository _v_MV_CPTE_OBSERVRepository;
		public V_MV_CPTE_OBSERVRepository V_MV_CPTE_OBSERV {get => _v_MV_CPTE_OBSERVRepository;}

		private V_MV_CpteAccionesRepository _v_MV_CpteAccionesRepository;
		public V_MV_CpteAccionesRepository V_MV_CpteAcciones {get => _v_MV_CpteAccionesRepository;}

		private V_MV_CpteDocRepository _v_MV_CpteDocRepository;
		public V_MV_CpteDocRepository V_MV_CpteDoc {get => _v_MV_CpteDocRepository;}

		private V_MV_CpteEnComisionRepository _v_MV_CpteEnComisionRepository;
		public V_MV_CpteEnComisionRepository V_MV_CpteEnComision {get => _v_MV_CpteEnComisionRepository;}

		private V_MV_CpteInsumosRepository _v_MV_CpteInsumosRepository;
		public V_MV_CpteInsumosRepository V_MV_CpteInsumos {get => _v_MV_CpteInsumosRepository;}

		private V_MV_CpteTareasRepository _v_MV_CpteTareasRepository;
		public V_MV_CpteTareasRepository V_MV_CpteTareas {get => _v_MV_CpteTareasRepository;}

		private V_MV_CpteTercerosRepository _v_MV_CpteTercerosRepository;
		public V_MV_CpteTercerosRepository V_MV_CpteTerceros {get => _v_MV_CpteTercerosRepository;}

		private v_mv_crealesRepository _v_mv_crealesRepository;
		public v_mv_crealesRepository v_mv_creales {get => _v_mv_crealesRepository;}

		private v_mv_creales_AplicacionRepository _v_mv_creales_AplicacionRepository;
		public v_mv_creales_AplicacionRepository v_mv_creales_Aplicacion {get => _v_mv_creales_AplicacionRepository;}

		private V_MV_CUOTASRepository _v_MV_CUOTASRepository;
		public V_MV_CUOTASRepository V_MV_CUOTAS {get => _v_MV_CUOTASRepository;}

		private V_MV_DiariosRepository _v_MV_DiariosRepository;
		public V_MV_DiariosRepository V_MV_Diarios {get => _v_MV_DiariosRepository;}

		private V_MV_PreciosHisRepository _v_MV_PreciosHisRepository;
		public V_MV_PreciosHisRepository V_MV_PreciosHis {get => _v_MV_PreciosHisRepository;}

		private V_MV_SOLICITUD_ARTICULOSRepository _v_MV_SOLICITUD_ARTICULOSRepository;
		public V_MV_SOLICITUD_ARTICULOSRepository V_MV_SOLICITUD_ARTICULOS {get => _v_MV_SOLICITUD_ARTICULOSRepository;}

		private V_MV_StockRepository _v_MV_StockRepository;
		public V_MV_StockRepository V_MV_Stock {get => _v_MV_StockRepository;}

		private V_TA_ALERTAS_STOCKRepository _v_TA_ALERTAS_STOCKRepository;
		public V_TA_ALERTAS_STOCKRepository V_TA_ALERTAS_STOCK {get => _v_TA_ALERTAS_STOCKRepository;}

		private V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository _v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository;
		public V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOS {get => _v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository;}

		private V_TA_ATRIBUTOS_PROD_ARTICULOSRepository _v_TA_ATRIBUTOS_PROD_ARTICULOSRepository;
		public V_TA_ATRIBUTOS_PROD_ARTICULOSRepository V_TA_ATRIBUTOS_PROD_ARTICULOS {get => _v_TA_ATRIBUTOS_PROD_ARTICULOSRepository;}

		private V_TA_BancosRepository _v_TA_BancosRepository;
		public V_TA_BancosRepository V_TA_Bancos {get => _v_TA_BancosRepository;}

		private V_TA_BONIFICACIONES_COMPRASRepository _v_TA_BONIFICACIONES_COMPRASRepository;
		public V_TA_BONIFICACIONES_COMPRASRepository V_TA_BONIFICACIONES_COMPRAS {get => _v_TA_BONIFICACIONES_COMPRASRepository;}

		private V_Ta_CajasRepository _v_Ta_CajasRepository;
		public V_Ta_CajasRepository V_Ta_Cajas {get => _v_Ta_CajasRepository;}

		private V_TA_CATALOGOS_HTMRepository _v_TA_CATALOGOS_HTMRepository;
		public V_TA_CATALOGOS_HTMRepository V_TA_CATALOGOS_HTM {get => _v_TA_CATALOGOS_HTMRepository;}

		private V_TA_CATALOGOS_HTM_DETALLERepository _v_TA_CATALOGOS_HTM_DETALLERepository;
		public V_TA_CATALOGOS_HTM_DETALLERepository V_TA_CATALOGOS_HTM_DETALLE {get => _v_TA_CATALOGOS_HTM_DETALLERepository;}

		private V_TA_CategoriaRepository _v_TA_CategoriaRepository;
		public V_TA_CategoriaRepository V_TA_Categoria {get => _v_TA_CategoriaRepository;}

		private V_TA_CLASIFICACION_CREDITICIARepository _v_TA_CLASIFICACION_CREDITICIARepository;
		public V_TA_CLASIFICACION_CREDITICIARepository V_TA_CLASIFICACION_CREDITICIA {get => _v_TA_CLASIFICACION_CREDITICIARepository;}

		private V_TA_COMBOSRepository _v_TA_COMBOSRepository;
		public V_TA_COMBOSRepository V_TA_COMBOS {get => _v_TA_COMBOSRepository;}

		private V_TA_COMBOS_DETALLERepository _v_TA_COMBOS_DETALLERepository;
		public V_TA_COMBOS_DETALLERepository V_TA_COMBOS_DETALLE {get => _v_TA_COMBOS_DETALLERepository;}

		private V_TA_CONFIG_IMPRESION_CPTESRepository _v_TA_CONFIG_IMPRESION_CPTESRepository;
		public V_TA_CONFIG_IMPRESION_CPTESRepository V_TA_CONFIG_IMPRESION_CPTES {get => _v_TA_CONFIG_IMPRESION_CPTESRepository;}

		private V_TA_Cpra_VtaRepository _v_TA_Cpra_VtaRepository;
		public V_TA_Cpra_VtaRepository V_TA_Cpra_Vta {get => _v_TA_Cpra_VtaRepository;}

		private V_TA_CpteRepository _v_TA_CpteRepository;
		public V_TA_CpteRepository V_TA_Cpte {get => _v_TA_CpteRepository;}

		private V_TA_CTRL_CHEQUERASRepository _v_TA_CTRL_CHEQUERASRepository;
		public V_TA_CTRL_CHEQUERASRepository V_TA_CTRL_CHEQUERAS {get => _v_TA_CTRL_CHEQUERASRepository;}

		private V_TA_CuentasComisionRepository _v_TA_CuentasComisionRepository;
		public V_TA_CuentasComisionRepository V_TA_CuentasComision {get => _v_TA_CuentasComisionRepository;}

		private V_TA_DEPOSITORepository _v_TA_DEPOSITORepository;
		public V_TA_DEPOSITORepository V_TA_DEPOSITO {get => _v_TA_DEPOSITORepository;}

		private V_TA_DEPOSITO_MMRepository _v_TA_DEPOSITO_MMRepository;
		public V_TA_DEPOSITO_MMRepository V_TA_DEPOSITO_MM {get => _v_TA_DEPOSITO_MMRepository;}

		private V_TA_DESTINORepository _v_TA_DESTINORepository;
		public V_TA_DESTINORepository V_TA_DESTINO {get => _v_TA_DESTINORepository;}

		private V_TA_ESCALARETENCIONESRepository _v_TA_ESCALARETENCIONESRepository;
		public V_TA_ESCALARETENCIONESRepository V_TA_ESCALARETENCIONES {get => _v_TA_ESCALARETENCIONESRepository;}

		private V_TA_ESTADO_VISITASRepository _v_TA_ESTADO_VISITASRepository;
		public V_TA_ESTADO_VISITASRepository V_TA_ESTADO_VISITAS {get => _v_TA_ESTADO_VISITASRepository;}

		private V_TA_FAMILIASRepository _v_TA_FAMILIASRepository;
		public V_TA_FAMILIASRepository V_TA_FAMILIAS {get => _v_TA_FAMILIASRepository;}

		private V_TA_GARANTIASRepository _v_TA_GARANTIASRepository;
		public V_TA_GARANTIASRepository V_TA_GARANTIAS {get => _v_TA_GARANTIASRepository;}

		private V_TA_Input_ComprasRepository _v_TA_Input_ComprasRepository;
		public V_TA_Input_ComprasRepository V_TA_Input_Compras {get => _v_TA_Input_ComprasRepository;}

		private V_TA_Input_VentasRepository _v_TA_Input_VentasRepository;
		public V_TA_Input_VentasRepository V_TA_Input_Ventas {get => _v_TA_Input_VentasRepository;}

		private V_TA_INTERFACESRepository _v_TA_INTERFACESRepository;
		public V_TA_INTERFACESRepository V_TA_INTERFACES {get => _v_TA_INTERFACESRepository;}

		private V_TA_Interfaces_asignacionCamposRepository _v_TA_Interfaces_asignacionCamposRepository;
		public V_TA_Interfaces_asignacionCamposRepository V_TA_Interfaces_asignacionCampos {get => _v_TA_Interfaces_asignacionCamposRepository;}

		private V_TA_Interfaces_DetalleRepository _v_TA_Interfaces_DetalleRepository;
		public V_TA_Interfaces_DetalleRepository V_TA_Interfaces_Detalle {get => _v_TA_Interfaces_DetalleRepository;}

		private V_TA_Interfaces_EquivalenciaRepository _v_TA_Interfaces_EquivalenciaRepository;
		public V_TA_Interfaces_EquivalenciaRepository V_TA_Interfaces_Equivalencia {get => _v_TA_Interfaces_EquivalenciaRepository;}

		private V_TA_INTERFACES_FILTROSRepository _v_TA_INTERFACES_FILTROSRepository;
		public V_TA_INTERFACES_FILTROSRepository V_TA_INTERFACES_FILTROS {get => _v_TA_INTERFACES_FILTROSRepository;}

		private V_TA_MOTIVO_AJUSTESRepository _v_TA_MOTIVO_AJUSTESRepository;
		public V_TA_MOTIVO_AJUSTESRepository V_TA_MOTIVO_AJUSTES {get => _v_TA_MOTIVO_AJUSTESRepository;}

		private V_TA_MOTIVO_BAJA_CUENTASRepository _v_TA_MOTIVO_BAJA_CUENTASRepository;
		public V_TA_MOTIVO_BAJA_CUENTASRepository V_TA_MOTIVO_BAJA_CUENTAS {get => _v_TA_MOTIVO_BAJA_CUENTASRepository;}

		private V_TA_MotivoCpraRepository _v_TA_MotivoCpraRepository;
		public V_TA_MotivoCpraRepository V_TA_MotivoCpra {get => _v_TA_MotivoCpraRepository;}

		private V_TA_MOTIVOS_ANULACIONESRepository _v_TA_MOTIVOS_ANULACIONESRepository;
		public V_TA_MOTIVOS_ANULACIONESRepository V_TA_MOTIVOS_ANULACIONES {get => _v_TA_MOTIVOS_ANULACIONESRepository;}

		private V_TA_MotivoStockRepository _v_TA_MotivoStockRepository;
		public V_TA_MotivoStockRepository V_TA_MotivoStock {get => _v_TA_MotivoStockRepository;}

		private V_TA_MotivoVtaRepository _v_TA_MotivoVtaRepository;
		public V_TA_MotivoVtaRepository V_TA_MotivoVta {get => _v_TA_MotivoVtaRepository;}

		private V_TA_OrigenRepository _v_TA_OrigenRepository;
		public V_TA_OrigenRepository V_TA_Origen {get => _v_TA_OrigenRepository;}

		private V_TA_PercepcionRepository _v_TA_PercepcionRepository;
		public V_TA_PercepcionRepository V_TA_Percepcion {get => _v_TA_PercepcionRepository;}

		private V_TA_PLANTILLA_FORMULARIOSRepository _v_TA_PLANTILLA_FORMULARIOSRepository;
		public V_TA_PLANTILLA_FORMULARIOSRepository V_TA_PLANTILLA_FORMULARIOS {get => _v_TA_PLANTILLA_FORMULARIOSRepository;}

		private V_TA_PoliticaPreciosRepository _v_TA_PoliticaPreciosRepository;
		public V_TA_PoliticaPreciosRepository V_TA_PoliticaPrecios {get => _v_TA_PoliticaPreciosRepository;}

		private V_TA_PROCESOS_PRODUCTIVOSRepository _v_TA_PROCESOS_PRODUCTIVOSRepository;
		public V_TA_PROCESOS_PRODUCTIVOSRepository V_TA_PROCESOS_PRODUCTIVOS {get => _v_TA_PROCESOS_PRODUCTIVOSRepository;}

		private V_TA_REPORTES_PERSONALIZADOSRepository _v_TA_REPORTES_PERSONALIZADOSRepository;
		public V_TA_REPORTES_PERSONALIZADOSRepository V_TA_REPORTES_PERSONALIZADOS {get => _v_TA_REPORTES_PERSONALIZADOSRepository;}

		private V_TA_REPORTES_PERSONALIZADOS_DETALLERepository _v_TA_REPORTES_PERSONALIZADOS_DETALLERepository;
		public V_TA_REPORTES_PERSONALIZADOS_DETALLERepository V_TA_REPORTES_PERSONALIZADOS_DETALLE {get => _v_TA_REPORTES_PERSONALIZADOS_DETALLERepository;}

		private V_TA_RETENCIONESRepository _v_TA_RETENCIONESRepository;
		public V_TA_RETENCIONESRepository V_TA_RETENCIONES {get => _v_TA_RETENCIONESRepository;}

		private V_TA_RubrosRepository _v_TA_RubrosRepository;
		public V_TA_RubrosRepository V_TA_Rubros {get => _v_TA_RubrosRepository;}

		private V_TA_SECTORESRepository _v_TA_SECTORESRepository;
		public V_TA_SECTORESRepository V_TA_SECTORES {get => _v_TA_SECTORESRepository;}

		private V_TA_STATUS_NPRepository _v_TA_STATUS_NPRepository;
		public V_TA_STATUS_NPRepository V_TA_STATUS_NP {get => _v_TA_STATUS_NPRepository;}

		private V_TA_STATUS_OPRepository _v_TA_STATUS_OPRepository;
		public V_TA_STATUS_OPRepository V_TA_STATUS_OP {get => _v_TA_STATUS_OPRepository;}

		private V_TA_SUCURSALESRepository _v_TA_SUCURSALESRepository;
		public V_TA_SUCURSALESRepository V_TA_SUCURSALES {get => _v_TA_SUCURSALESRepository;}

		private V_TA_TareasRepository _v_TA_TareasRepository;
		public V_TA_TareasRepository V_TA_Tareas {get => _v_TA_TareasRepository;}

		private V_TA_TecnicosRepository _v_TA_TecnicosRepository;
		public V_TA_TecnicosRepository V_TA_Tecnicos {get => _v_TA_TecnicosRepository;}

		private V_TA_TEMPORADASRepository _v_TA_TEMPORADASRepository;
		public V_TA_TEMPORADASRepository V_TA_TEMPORADAS {get => _v_TA_TEMPORADASRepository;}

		private V_TA_TipoArticuloRepository _v_TA_TipoArticuloRepository;
		public V_TA_TipoArticuloRepository V_TA_TipoArticulo {get => _v_TA_TipoArticuloRepository;}

		private V_TA_UnidadRepository _v_TA_UnidadRepository;
		public V_TA_UnidadRepository V_TA_Unidad {get => _v_TA_UnidadRepository;}

		private V_TA_VENDEDORESRepository _v_TA_VENDEDORESRepository;
		public V_TA_VENDEDORESRepository V_TA_VENDEDORES {get => _v_TA_VENDEDORESRepository;}

		private V_TA_VENDEDORES_ALERTASRepository _v_TA_VENDEDORES_ALERTASRepository;
		public V_TA_VENDEDORES_ALERTASRepository V_TA_VENDEDORES_ALERTAS {get => _v_TA_VENDEDORES_ALERTASRepository;}

		private V_TA_ZONASRepository _v_TA_ZONASRepository;
		public V_TA_ZONASRepository V_TA_ZONAS {get => _v_TA_ZONASRepository;}


		//ViewManagers
		private AUX_MV_CPTE_COBRANZASViewManager _aUX_MV_CPTE_COBRANZASViewManager;
		public AUX_MV_CPTE_COBRANZASViewManager AUX_MV_CPTE_COBRANZAS {get => _aUX_MV_CPTE_COBRANZASViewManager;}

		private AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager _aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager;
		public AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager AUX_MV_CPTE_COBRANZAS_COMPROBANTES {get => _aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager;}

		private AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager _aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager;
		public AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGO {get => _aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager;}

		private AuxObtieneNetoViewManager _auxObtieneNetoViewManager;
		public AuxObtieneNetoViewManager AuxObtieneNeto {get => _auxObtieneNetoViewManager;}

		private C_BusquedaPreciosProveedorDtoCpraViewManager _c_BusquedaPreciosProveedorDtoCpraViewManager;
		public C_BusquedaPreciosProveedorDtoCpraViewManager C_BusquedaPreciosProveedorDtoCpra {get => _c_BusquedaPreciosProveedorDtoCpraViewManager;}

		private C_MV_CPTE_RANKING_CONSUMOViewManager _c_MV_CPTE_RANKING_CONSUMOViewManager;
		public C_MV_CPTE_RANKING_CONSUMOViewManager C_MV_CPTE_RANKING_CONSUMO {get => _c_MV_CPTE_RANKING_CONSUMOViewManager;}

		private C_RemitosConCobranzasViewManager _c_RemitosConCobranzasViewManager;
		public C_RemitosConCobranzasViewManager C_RemitosConCobranzas {get => _c_RemitosConCobranzasViewManager;}

		private C_RemitosFacturadosViewManager _c_RemitosFacturadosViewManager;
		public C_RemitosFacturadosViewManager C_RemitosFacturados {get => _c_RemitosFacturadosViewManager;}

		private c_RemitosPendientesViewManager _c_RemitosPendientesViewManager;
		public c_RemitosPendientesViewManager c_RemitosPendientes {get => _c_RemitosPendientesViewManager;}

		private C_RemitosPendientesSinProveedorViewManager _c_RemitosPendientesSinProveedorViewManager;
		public C_RemitosPendientesSinProveedorViewManager C_RemitosPendientesSinProveedor {get => _c_RemitosPendientesSinProveedorViewManager;}

		private C_RemitosSinAplicacionViewManager _c_RemitosSinAplicacionViewManager;
		public C_RemitosSinAplicacionViewManager C_RemitosSinAplicacion {get => _c_RemitosSinAplicacionViewManager;}

		private ChequesFirmadosNoConciliadosViewManager _chequesFirmadosNoConciliadosViewManager;
		public ChequesFirmadosNoConciliadosViewManager ChequesFirmadosNoConciliados {get => _chequesFirmadosNoConciliadosViewManager;}

		private CO_AplicacionOCViewManager _cO_AplicacionOCViewManager;
		public CO_AplicacionOCViewManager CO_AplicacionOC {get => _cO_AplicacionOCViewManager;}

		private CO_CPTES_CREDITOS_PENDIENTESViewManager _cO_CPTES_CREDITOS_PENDIENTESViewManager;
		public CO_CPTES_CREDITOS_PENDIENTESViewManager CO_CPTES_CREDITOS_PENDIENTES {get => _cO_CPTES_CREDITOS_PENDIENTESViewManager;}

		private CO_CPTES_IMPAGOSViewManager _cO_CPTES_IMPAGOSViewManager;
		public CO_CPTES_IMPAGOSViewManager CO_CPTES_IMPAGOS {get => _cO_CPTES_IMPAGOSViewManager;}

		private CO_FaltantesOCViewManager _cO_FaltantesOCViewManager;
		public CO_FaltantesOCViewManager CO_FaltantesOC {get => _cO_FaltantesOCViewManager;}

		private CO_FCCore_PendientesViewManager _cO_FCCore_PendientesViewManager;
		public CO_FCCore_PendientesViewManager CO_FCCore_Pendientes {get => _cO_FCCore_PendientesViewManager;}

		private CO_OCompraPendientesViewManager _cO_OCompraPendientesViewManager;
		public CO_OCompraPendientesViewManager CO_OCompraPendientes {get => _cO_OCompraPendientesViewManager;}

		private CO_OCompraPendientes_DetalleViewManager _cO_OCompraPendientes_DetalleViewManager;
		public CO_OCompraPendientes_DetalleViewManager CO_OCompraPendientes_Detalle {get => _cO_OCompraPendientes_DetalleViewManager;}

		private GM_PLANILLASViewManager _gM_PLANILLASViewManager;
		public GM_PLANILLASViewManager GM_PLANILLAS {get => _gM_PLANILLASViewManager;}

		private LibroIvaComprasViewManager _libroIvaComprasViewManager;
		public LibroIvaComprasViewManager LibroIvaCompras {get => _libroIvaComprasViewManager;}

		private LibroIvaVentasViewManager _libroIvaVentasViewManager;
		public LibroIvaVentasViewManager LibroIvaVentas {get => _libroIvaVentasViewManager;}

		private LibroIvaVentasDirecto_ConsignadoViewManager _libroIvaVentasDirecto_ConsignadoViewManager;
		public LibroIvaVentasDirecto_ConsignadoViewManager LibroIvaVentasDirecto_Consignado {get => _libroIvaVentasDirecto_ConsignadoViewManager;}

		private LibroIvaVentasPorPeriodoViewManager _libroIvaVentasPorPeriodoViewManager;
		public LibroIvaVentasPorPeriodoViewManager LibroIvaVentasPorPeriodo {get => _libroIvaVentasPorPeriodoViewManager;}

		private LibroIvaVentasResumenViewManager _libroIvaVentasResumenViewManager;
		public LibroIvaVentasResumenViewManager LibroIvaVentasResumen {get => _libroIvaVentasResumenViewManager;}

		private NW_DOCUMENTADORViewManager _nW_DOCUMENTADORViewManager;
		public NW_DOCUMENTADORViewManager NW_DOCUMENTADOR {get => _nW_DOCUMENTADORViewManager;}

		private P_AUX_LEGAJOSViewManager _p_AUX_LEGAJOSViewManager;
		public P_AUX_LEGAJOSViewManager P_AUX_LEGAJOS {get => _p_AUX_LEGAJOSViewManager;}

		private P_EntrevistasViewManager _p_EntrevistasViewManager;
		public P_EntrevistasViewManager P_Entrevistas {get => _p_EntrevistasViewManager;}

		private P_ENTREVISTASEVALUACIONESViewManager _p_ENTREVISTASEVALUACIONESViewManager;
		public P_ENTREVISTASEVALUACIONESViewManager P_ENTREVISTASEVALUACIONES {get => _p_ENTREVISTASEVALUACIONESViewManager;}

		private P_EntrevistasFHViewManager _p_EntrevistasFHViewManager;
		public P_EntrevistasFHViewManager P_EntrevistasFH {get => _p_EntrevistasFHViewManager;}

		private P_EntrevistasPendientesViewManager _p_EntrevistasPendientesViewManager;
		public P_EntrevistasPendientesViewManager P_EntrevistasPendientes {get => _p_EntrevistasPendientesViewManager;}

		private P_EntrevistasPendientesFhViewManager _p_EntrevistasPendientesFhViewManager;
		public P_EntrevistasPendientesFhViewManager P_EntrevistasPendientesFh {get => _p_EntrevistasPendientesFhViewManager;}

		private P_EvaluacionesViewManager _p_EvaluacionesViewManager;
		public P_EvaluacionesViewManager P_Evaluaciones {get => _p_EvaluacionesViewManager;}

		private P_EvaluacionesPendientesViewManager _p_EvaluacionesPendientesViewManager;
		public P_EvaluacionesPendientesViewManager P_EvaluacionesPendientes {get => _p_EvaluacionesPendientesViewManager;}

		private P_SaldosClientesViewManager _p_SaldosClientesViewManager;
		public P_SaldosClientesViewManager P_SaldosClientes {get => _p_SaldosClientesViewManager;}

		private P_SaldosClientesBusquedasViewManager _p_SaldosClientesBusquedasViewManager;
		public P_SaldosClientesBusquedasViewManager P_SaldosClientesBusquedas {get => _p_SaldosClientesBusquedasViewManager;}

		private P_Sind_CategoriasViewManager _p_Sind_CategoriasViewManager;
		public P_Sind_CategoriasViewManager P_Sind_Categorias {get => _p_Sind_CategoriasViewManager;}

		private P_SindCatCargosViewManager _p_SindCatCargosViewManager;
		public P_SindCatCargosViewManager P_SindCatCargos {get => _p_SindCatCargosViewManager;}

		private P_SindicatosViewManager _p_SindicatosViewManager;
		public P_SindicatosViewManager P_Sindicatos {get => _p_SindicatosViewManager;}

		private P_SolucitudesViewManager _p_SolucitudesViewManager;
		public P_SolucitudesViewManager P_Solucitudes {get => _p_SolucitudesViewManager;}

		private P_SolucitudesAFinalizarViewManager _p_SolucitudesAFinalizarViewManager;
		public P_SolucitudesAFinalizarViewManager P_SolucitudesAFinalizar {get => _p_SolucitudesAFinalizarViewManager;}

		private P_SolucitudesPostulantesViewManager _p_SolucitudesPostulantesViewManager;
		public P_SolucitudesPostulantesViewManager P_SolucitudesPostulantes {get => _p_SolucitudesPostulantesViewManager;}

		private P_TodasLasSolicitudesViewManager _p_TodasLasSolicitudesViewManager;
		public P_TodasLasSolicitudesViewManager P_TodasLasSolicitudes {get => _p_TodasLasSolicitudesViewManager;}

		private P_TodasLasSolicitudesPostViewManager _p_TodasLasSolicitudesPostViewManager;
		public P_TodasLasSolicitudesPostViewManager P_TodasLasSolicitudesPost {get => _p_TodasLasSolicitudesPostViewManager;}

		private P_TodasLasSolicitudesPostulantesViewManager _p_TodasLasSolicitudesPostulantesViewManager;
		public P_TodasLasSolicitudesPostulantesViewManager P_TodasLasSolicitudesPostulantes {get => _p_TodasLasSolicitudesPostulantesViewManager;}

		private RANKING_CONSUMOViewManager _rANKING_CONSUMOViewManager;
		public RANKING_CONSUMOViewManager RANKING_CONSUMO {get => _rANKING_CONSUMOViewManager;}

		private Stk_Ma_ArticulosViewManager _stk_Ma_ArticulosViewManager;
		public Stk_Ma_ArticulosViewManager Stk_Ma_Articulos {get => _stk_Ma_ArticulosViewManager;}

		private STK_PuntoReposicionViewManager _sTK_PuntoReposicionViewManager;
		public STK_PuntoReposicionViewManager STK_PuntoReposicion {get => _sTK_PuntoReposicionViewManager;}

		private STK_SALDOS_ART_CON_TROPAViewManager _sTK_SALDOS_ART_CON_TROPAViewManager;
		public STK_SALDOS_ART_CON_TROPAViewManager STK_SALDOS_ART_CON_TROPA {get => _sTK_SALDOS_ART_CON_TROPAViewManager;}

		private STK_SALDOS_SLViewManager _sTK_SALDOS_SLViewManager;
		public STK_SALDOS_SLViewManager STK_SALDOS_SL {get => _sTK_SALDOS_SLViewManager;}

		private STK_SALDOS_UnidadesViewManager _sTK_SALDOS_UnidadesViewManager;
		public STK_SALDOS_UnidadesViewManager STK_SALDOS_Unidades {get => _sTK_SALDOS_UnidadesViewManager;}

		private STK_SERIES_Y_LOTESViewManager _sTK_SERIES_Y_LOTESViewManager;
		public STK_SERIES_Y_LOTESViewManager STK_SERIES_Y_LOTES {get => _sTK_SERIES_Y_LOTESViewManager;}

		private STK_STOCK_EQUIVViewManager _sTK_STOCK_EQUIVViewManager;
		public STK_STOCK_EQUIVViewManager STK_STOCK_EQUIV {get => _sTK_STOCK_EQUIVViewManager;}

		private SW_DOCUMENTADORViewManager _sW_DOCUMENTADORViewManager;
		public SW_DOCUMENTADORViewManager SW_DOCUMENTADOR {get => _sW_DOCUMENTADORViewManager;}

		private SW_TABLAS_CON_CAMPOSViewManager _sW_TABLAS_CON_CAMPOSViewManager;
		public SW_TABLAS_CON_CAMPOSViewManager SW_TABLAS_CON_CAMPOS {get => _sW_TABLAS_CON_CAMPOSViewManager;}

		private SW_TABLAS_SISTEMAViewManager _sW_TABLAS_SISTEMAViewManager;
		public SW_TABLAS_SISTEMAViewManager SW_TABLAS_SISTEMA {get => _sW_TABLAS_SISTEMAViewManager;}

		private tmp_cuotasViewManager _tmp_cuotasViewManager;
		public tmp_cuotasViewManager tmp_cuotas {get => _tmp_cuotasViewManager;}

		private V_Aplicacion_OrdenDePagoViewManager _v_Aplicacion_OrdenDePagoViewManager;
		public V_Aplicacion_OrdenDePagoViewManager V_Aplicacion_OrdenDePago {get => _v_Aplicacion_OrdenDePagoViewManager;}

		private V_AsientosCCostoViewManager _v_AsientosCCostoViewManager;
		public V_AsientosCCostoViewManager V_AsientosCCosto {get => _v_AsientosCCostoViewManager;}

		private v_chequesconciliadosViewManager _v_chequesconciliadosViewManager;
		public v_chequesconciliadosViewManager v_chequesconciliados {get => _v_chequesconciliadosViewManager;}

		private V_ChequesEnCarteraViewManager _v_ChequesEnCarteraViewManager;
		public V_ChequesEnCarteraViewManager V_ChequesEnCartera {get => _v_ChequesEnCarteraViewManager;}

		private V_ChequesEntregadosViewManager _v_ChequesEntregadosViewManager;
		public V_ChequesEntregadosViewManager V_ChequesEntregados {get => _v_ChequesEntregadosViewManager;}

		private V_ChequesFirmadosViewManager _v_ChequesFirmadosViewManager;
		public V_ChequesFirmadosViewManager V_ChequesFirmados {get => _v_ChequesFirmadosViewManager;}

		private V_ChequesFirmadosNoConciliadosViewManager _v_ChequesFirmadosNoConciliadosViewManager;
		public V_ChequesFirmadosNoConciliadosViewManager V_ChequesFirmadosNoConciliados {get => _v_ChequesFirmadosNoConciliadosViewManager;}

		private V_ChequesRecibidosViewManager _v_ChequesRecibidosViewManager;
		public V_ChequesRecibidosViewManager V_ChequesRecibidos {get => _v_ChequesRecibidosViewManager;}

		private V_COBRANZASPORUSUARIOViewManager _v_COBRANZASPORUSUARIOViewManager;
		public V_COBRANZASPORUSUARIOViewManager V_COBRANZASPORUSUARIO {get => _v_COBRANZASPORUSUARIOViewManager;}

		private V_ConsultaDeRubroTipoProveedorViewManager _v_ConsultaDeRubroTipoProveedorViewManager;
		public V_ConsultaDeRubroTipoProveedorViewManager V_ConsultaDeRubroTipoProveedor {get => _v_ConsultaDeRubroTipoProveedorViewManager;}

		private V_ConsultaDeRubroTipoProveerdorArticulosViewManager _v_ConsultaDeRubroTipoProveerdorArticulosViewManager;
		public V_ConsultaDeRubroTipoProveerdorArticulosViewManager V_ConsultaDeRubroTipoProveerdorArticulos {get => _v_ConsultaDeRubroTipoProveerdorArticulosViewManager;}

		private V_EstadoBancarioViewManager _v_EstadoBancarioViewManager;
		public V_EstadoBancarioViewManager V_EstadoBancario {get => _v_EstadoBancarioViewManager;}

		private V_ImportesAplicadosViewManager _v_ImportesAplicadosViewManager;
		public V_ImportesAplicadosViewManager V_ImportesAplicados {get => _v_ImportesAplicadosViewManager;}

		private V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager _v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager;
		public V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOS {get => _v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager;}

		private v_mv_CargosAplicadosViewManager _v_mv_CargosAplicadosViewManager;
		public v_mv_CargosAplicadosViewManager v_mv_CargosAplicados {get => _v_mv_CargosAplicadosViewManager;}

		private V_NP_PendientesViewManager _v_NP_PendientesViewManager;
		public V_NP_PendientesViewManager V_NP_Pendientes {get => _v_NP_PendientesViewManager;}

		private V_NP_PENDIENTES_COMPROMETIDOViewManager _v_NP_PENDIENTES_COMPROMETIDOViewManager;
		public V_NP_PENDIENTES_COMPROMETIDOViewManager V_NP_PENDIENTES_COMPROMETIDO {get => _v_NP_PENDIENTES_COMPROMETIDOViewManager;}

		private V_NP_PENDIENTES2ViewManager _v_NP_PENDIENTES2ViewManager;
		public V_NP_PENDIENTES2ViewManager V_NP_PENDIENTES2 {get => _v_NP_PENDIENTES2ViewManager;}

		private V_OF_PENDIENTESViewManager _v_OF_PENDIENTESViewManager;
		public V_OF_PENDIENTESViewManager V_OF_PENDIENTES {get => _v_OF_PENDIENTESViewManager;}

		private V_OT_PendientesViewManager _v_OT_PendientesViewManager;
		public V_OT_PendientesViewManager V_OT_Pendientes {get => _v_OT_PendientesViewManager;}

		private V_PR_PendientesViewManager _v_PR_PendientesViewManager;
		public V_PR_PendientesViewManager V_PR_Pendientes {get => _v_PR_PendientesViewManager;}

		private V_RemitosConCobranzasViewManager _v_RemitosConCobranzasViewManager;
		public V_RemitosConCobranzasViewManager V_RemitosConCobranzas {get => _v_RemitosConCobranzasViewManager;}

		private V_RemitosFacturadosViewManager _v_RemitosFacturadosViewManager;
		public V_RemitosFacturadosViewManager V_RemitosFacturados {get => _v_RemitosFacturadosViewManager;}

		private V_RemitosPendientesViewManager _v_RemitosPendientesViewManager;
		public V_RemitosPendientesViewManager V_RemitosPendientes {get => _v_RemitosPendientesViewManager;}

		private V_RemitosSinAplicacionViewManager _v_RemitosSinAplicacionViewManager;
		public V_RemitosSinAplicacionViewManager V_RemitosSinAplicacion {get => _v_RemitosSinAplicacionViewManager;}

		private VE_CPTES_CREDITOS_PENDIENTESViewManager _vE_CPTES_CREDITOS_PENDIENTESViewManager;
		public VE_CPTES_CREDITOS_PENDIENTESViewManager VE_CPTES_CREDITOS_PENDIENTES {get => _vE_CPTES_CREDITOS_PENDIENTESViewManager;}

		private VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager _vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager;
		public VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager VE_CPTES_CREDITOS_PENDIENTES_SINREMITOS {get => _vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager;}

		private VE_CPTES_IMPAGOSViewManager _vE_CPTES_IMPAGOSViewManager;
		public VE_CPTES_IMPAGOSViewManager VE_CPTES_IMPAGOS {get => _vE_CPTES_IMPAGOSViewManager;}

		private VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager _vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager;
		public VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager VE_CPTES_IMPAGOS_CON_DETALLE_CPTE {get => _vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager;}

		private VE_CPTES_SALDOSViewManager _vE_CPTES_SALDOSViewManager;
		public VE_CPTES_SALDOSViewManager VE_CPTES_SALDOS {get => _vE_CPTES_SALDOSViewManager;}

		private VE_CPTES_SALDOS_HABERViewManager _vE_CPTES_SALDOS_HABERViewManager;
		public VE_CPTES_SALDOS_HABERViewManager VE_CPTES_SALDOS_HABER {get => _vE_CPTES_SALDOS_HABERViewManager;}

		private VE_SALDOAPLICACIONViewManager _vE_SALDOAPLICACIONViewManager;
		public VE_SALDOAPLICACIONViewManager VE_SALDOAPLICACION {get => _vE_SALDOAPLICACIONViewManager;}

		private VE_SALDOAPLICACION_HABERViewManager _vE_SALDOAPLICACION_HABERViewManager;
		public VE_SALDOAPLICACION_HABERViewManager VE_SALDOAPLICACION_HABER {get => _vE_SALDOAPLICACION_HABERViewManager;}

		private VE_SALDOSCTAViewManager _vE_SALDOSCTAViewManager;
		public VE_SALDOSCTAViewManager VE_SALDOSCTA {get => _vE_SALDOSCTAViewManager;}

		private VE_SALDOSCTA_DEBEViewManager _vE_SALDOSCTA_DEBEViewManager;
		public VE_SALDOSCTA_DEBEViewManager VE_SALDOSCTA_DEBE {get => _vE_SALDOSCTA_DEBEViewManager;}

		private VE_SALDOSCTA_HABERViewManager _vE_SALDOSCTA_HABERViewManager;
		public VE_SALDOSCTA_HABERViewManager VE_SALDOSCTA_HABER {get => _vE_SALDOSCTA_HABERViewManager;}

		private VE_SALDOSVDORViewManager _vE_SALDOSVDORViewManager;
		public VE_SALDOSVDORViewManager VE_SALDOSVDOR {get => _vE_SALDOSVDORViewManager;}

		private VE_SALDOSVDOR_DEBEViewManager _vE_SALDOSVDOR_DEBEViewManager;
		public VE_SALDOSVDOR_DEBEViewManager VE_SALDOSVDOR_DEBE {get => _vE_SALDOSVDOR_DEBEViewManager;}

		private VE_SALDOSVDOR_HABERViewManager _vE_SALDOSVDOR_HABERViewManager;
		public VE_SALDOSVDOR_HABERViewManager VE_SALDOSVDOR_HABER {get => _vE_SALDOSVDOR_HABERViewManager;}

		private VT_C_MV_INSUMOS_APLICACIONViewManager _vT_C_MV_INSUMOS_APLICACIONViewManager;
		public VT_C_MV_INSUMOS_APLICACIONViewManager VT_C_MV_INSUMOS_APLICACION {get => _vT_C_MV_INSUMOS_APLICACIONViewManager;}

		private Vt_ClientesViewManager _vt_ClientesViewManager;
		public Vt_ClientesViewManager Vt_Clientes {get => _vt_ClientesViewManager;}

		private VT_CO_CPTE_DiferidoViewManager _vT_CO_CPTE_DiferidoViewManager;
		public VT_CO_CPTE_DiferidoViewManager VT_CO_CPTE_Diferido {get => _vT_CO_CPTE_DiferidoViewManager;}

		private VT_COBRANZASViewManager _vT_COBRANZASViewManager;
		public VT_COBRANZASViewManager VT_COBRANZAS {get => _vT_COBRANZASViewManager;}

		private VT_CPTE_DiferidoViewManager _vT_CPTE_DiferidoViewManager;
		public VT_CPTE_DiferidoViewManager VT_CPTE_Diferido {get => _vT_CPTE_DiferidoViewManager;}

		private VT_DEPOSITO_MMViewManager _vT_DEPOSITO_MMViewManager;
		public VT_DEPOSITO_MMViewManager VT_DEPOSITO_MM {get => _vT_DEPOSITO_MMViewManager;}

		private VT_DEPOSITO_MM_STOCKViewManager _vT_DEPOSITO_MM_STOCKViewManager;
		public VT_DEPOSITO_MM_STOCKViewManager VT_DEPOSITO_MM_STOCK {get => _vT_DEPOSITO_MM_STOCKViewManager;}

		private VT_ESTADISTICA_CLIENTESViewManager _vT_ESTADISTICA_CLIENTESViewManager;
		public VT_ESTADISTICA_CLIENTESViewManager VT_ESTADISTICA_CLIENTES {get => _vT_ESTADISTICA_CLIENTESViewManager;}

		private VT_ESTADISTICA_CLIENTES_COBRANZASViewManager _vT_ESTADISTICA_CLIENTES_COBRANZASViewManager;
		public VT_ESTADISTICA_CLIENTES_COBRANZASViewManager VT_ESTADISTICA_CLIENTES_COBRANZAS {get => _vT_ESTADISTICA_CLIENTES_COBRANZASViewManager;}

		private VT_ESTADISTICA_CLIENTES_ENTREGASViewManager _vT_ESTADISTICA_CLIENTES_ENTREGASViewManager;
		public VT_ESTADISTICA_CLIENTES_ENTREGASViewManager VT_ESTADISTICA_CLIENTES_ENTREGAS {get => _vT_ESTADISTICA_CLIENTES_ENTREGASViewManager;}

		private VT_MA_PRECIOSViewManager _vT_MA_PRECIOSViewManager;
		public VT_MA_PRECIOSViewManager VT_MA_PRECIOS {get => _vT_MA_PRECIOSViewManager;}

		private VT_MA_PRECIOS_ARTICULOSViewManager _vT_MA_PRECIOS_ARTICULOSViewManager;
		public VT_MA_PRECIOS_ARTICULOSViewManager VT_MA_PRECIOS_ARTICULOS {get => _vT_MA_PRECIOS_ARTICULOSViewManager;}

		private VT_MAX_NRO_CPTE_ASIENTOSViewManager _vT_MAX_NRO_CPTE_ASIENTOSViewManager;
		public VT_MAX_NRO_CPTE_ASIENTOSViewManager VT_MAX_NRO_CPTE_ASIENTOS {get => _vT_MAX_NRO_CPTE_ASIENTOSViewManager;}

		private VT_MV_APLICACIONViewManager _vT_MV_APLICACIONViewManager;
		public VT_MV_APLICACIONViewManager VT_MV_APLICACION {get => _vT_MV_APLICACIONViewManager;}

		private VT_MV_CUOTAS_IMPAGASViewManager _vT_MV_CUOTAS_IMPAGASViewManager;
		public VT_MV_CUOTAS_IMPAGASViewManager VT_MV_CUOTAS_IMPAGAS {get => _vT_MV_CUOTAS_IMPAGASViewManager;}

		private VT_MV_CUOTAS_PAGASViewManager _vT_MV_CUOTAS_PAGASViewManager;
		public VT_MV_CUOTAS_PAGASViewManager VT_MV_CUOTAS_PAGAS {get => _vT_MV_CUOTAS_PAGASViewManager;}

		private VT_MV_Diarios_DescripViewManager _vT_MV_Diarios_DescripViewManager;
		public VT_MV_Diarios_DescripViewManager VT_MV_Diarios_Descrip {get => _vT_MV_Diarios_DescripViewManager;}

		private VT_PLANILLASMovilesViewManager _vT_PLANILLASMovilesViewManager;
		public VT_PLANILLASMovilesViewManager VT_PLANILLASMoviles {get => _vT_PLANILLASMovilesViewManager;}

		private Vt_ProveedoresViewManager _vt_ProveedoresViewManager;
		public Vt_ProveedoresViewManager Vt_Proveedores {get => _vt_ProveedoresViewManager;}

		private VT_RankingConsumoViewManager _vT_RankingConsumoViewManager;
		public VT_RankingConsumoViewManager VT_RankingConsumo {get => _vT_RankingConsumoViewManager;}

		private VT_RankingConsumo_ClienteViewManager _vT_RankingConsumo_ClienteViewManager;
		public VT_RankingConsumo_ClienteViewManager VT_RankingConsumo_Cliente {get => _vT_RankingConsumo_ClienteViewManager;}

		private VT_RubroTipoArticulosDescripcionesViewManager _vT_RubroTipoArticulosDescripcionesViewManager;
		public VT_RubroTipoArticulosDescripcionesViewManager VT_RubroTipoArticulosDescripciones {get => _vT_RubroTipoArticulosDescripcionesViewManager;}

		private VT_RubroTipoDescripcionesViewManager _vT_RubroTipoDescripcionesViewManager;
		public VT_RubroTipoDescripcionesViewManager VT_RubroTipoDescripciones {get => _vT_RubroTipoDescripcionesViewManager;}

		private VT_TA_PLANTILLAS_FORMULARIOSViewManager _vT_TA_PLANTILLAS_FORMULARIOSViewManager;
		public VT_TA_PLANTILLAS_FORMULARIOSViewManager VT_TA_PLANTILLAS_FORMULARIOS {get => _vT_TA_PLANTILLAS_FORMULARIOSViewManager;}

		private VT_ULTIMOS_PRECIOS_COMPRAViewManager _vT_ULTIMOS_PRECIOS_COMPRAViewManager;
		public VT_ULTIMOS_PRECIOS_COMPRAViewManager VT_ULTIMOS_PRECIOS_COMPRA {get => _vT_ULTIMOS_PRECIOS_COMPRAViewManager;}

		private VT_ULTIMOS_PRECIOS_VENTAViewManager _vT_ULTIMOS_PRECIOS_VENTAViewManager;
		public VT_ULTIMOS_PRECIOS_VENTAViewManager VT_ULTIMOS_PRECIOS_VENTA {get => _vT_ULTIMOS_PRECIOS_VENTAViewManager;}

		private VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager _vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager;
		public VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager VT_V_MV_CPTE_CON_TABLAS_RELACIONADAS {get => _vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager;}

		private VT_V_MV_INSUMOS_APLICACIONViewManager _vT_V_MV_INSUMOS_APLICACIONViewManager;
		public VT_V_MV_INSUMOS_APLICACIONViewManager VT_V_MV_INSUMOS_APLICACION {get => _vT_V_MV_INSUMOS_APLICACIONViewManager;}

		private VT_V_TA_CPTEViewManager _vT_V_TA_CPTEViewManager;
		public VT_V_TA_CPTEViewManager VT_V_TA_CPTE {get => _vT_V_TA_CPTEViewManager;}

		private wsSysMobileArticulosViewManager _wsSysMobileArticulosViewManager;
		public wsSysMobileArticulosViewManager wsSysMobileArticulos {get => _wsSysMobileArticulosViewManager;}

		private wsSysMobileClientesViewManager _wsSysMobileClientesViewManager;
		public wsSysMobileClientesViewManager wsSysMobileClientes {get => _wsSysMobileClientesViewManager;}

		private wsSysMobileDepositosViewManager _wsSysMobileDepositosViewManager;
		public wsSysMobileDepositosViewManager wsSysMobileDepositos {get => _wsSysMobileDepositosViewManager;}

		private wsSysMobileRubrosViewManager _wsSysMobileRubrosViewManager;
		public wsSysMobileRubrosViewManager wsSysMobileRubros {get => _wsSysMobileRubrosViewManager;}

		private wsSysMobileStockArticulosViewManager _wsSysMobileStockArticulosViewManager;
		public wsSysMobileStockArticulosViewManager wsSysMobileStockArticulos {get => _wsSysMobileStockArticulosViewManager;}

		private wsSysMobileStockArticulosDepositosViewManager _wsSysMobileStockArticulosDepositosViewManager;
		public wsSysMobileStockArticulosDepositosViewManager wsSysMobileStockArticulosDepositos {get => _wsSysMobileStockArticulosDepositosViewManager;}

		private wsSysMobileStockComprometidoArticulosViewManager _wsSysMobileStockComprometidoArticulosViewManager;
		public wsSysMobileStockComprometidoArticulosViewManager wsSysMobileStockComprometidoArticulos {get => _wsSysMobileStockComprometidoArticulosViewManager;}

		private wsSysMobileTotalRegistrosTablasViewManager _wsSysMobileTotalRegistrosTablasViewManager;
		public wsSysMobileTotalRegistrosTablasViewManager wsSysMobileTotalRegistrosTablas {get => _wsSysMobileTotalRegistrosTablasViewManager;}

		private wsSysMobileVendedoresViewManager _wsSysMobileVendedoresViewManager;
		public wsSysMobileVendedoresViewManager wsSysMobileVendedores {get => _wsSysMobileVendedoresViewManager;}


		public Db(EDatabaseEngine databaseEngine, string connectionString) : base(databaseEngine, connectionString)
		{
			InitDataObjects();
		}
		public Db(string connectionString) : base(DefaultValues.DefaultDatabaseEngine, connectionString)
		{
			InitDataObjects();
		}

		public override void InitDataObjects()
		{
			//Repositories
			_aUX_ANEXOARepository  = new AUX_ANEXOARepository (ConnectionString,DatabaseEngine);
			_aUX_BALANCEGRALRepository  = new AUX_BALANCEGRALRepository (ConnectionString,DatabaseEngine);
			_aUX_EST_PRODRepository  = new AUX_EST_PRODRepository (ConnectionString,DatabaseEngine);
			_aUX_EstadisticaCtaRepository  = new AUX_EstadisticaCtaRepository (ConnectionString,DatabaseEngine);
			_aUX_MAYORESRepository  = new AUX_MAYORESRepository (ConnectionString,DatabaseEngine);
			_aux_MV_CpteRepository  = new Aux_MV_CpteRepository (ConnectionString,DatabaseEngine);
			_aux_MV_CpteQRRepository  = new Aux_MV_CpteQRRepository (ConnectionString,DatabaseEngine);
			_aUX_SALDOSMENSUALESRepository  = new AUX_SALDOSMENSUALESRepository (ConnectionString,DatabaseEngine);
			_aUX_SUBDIARIOSRepository  = new AUX_SUBDIARIOSRepository (ConnectionString,DatabaseEngine);
			_aUX_TMPRepository  = new AUX_TMPRepository (ConnectionString,DatabaseEngine);
			_aux_totalesRepository  = new Aux_totalesRepository (ConnectionString,DatabaseEngine);
			_aUX_TOTALES_DETRepository  = new AUX_TOTALES_DETRepository (ConnectionString,DatabaseEngine);
			_c_MV_CpteRepository  = new C_MV_CpteRepository (ConnectionString,DatabaseEngine);
			_c_MV_CPTE_OBSERVRepository  = new C_MV_CPTE_OBSERVRepository (ConnectionString,DatabaseEngine);
			_c_MV_CPTE_PERCEPCIONESRepository  = new C_MV_CPTE_PERCEPCIONESRepository (ConnectionString,DatabaseEngine);
			_c_MV_CpteInsumosRepository  = new C_MV_CpteInsumosRepository (ConnectionString,DatabaseEngine);
			_c_MV_CpteTareasRepository  = new C_MV_CpteTareasRepository (ConnectionString,DatabaseEngine);
			_c_Proveedores_CCompraRepository  = new C_Proveedores_CCompraRepository (ConnectionString,DatabaseEngine);
			_cONTROL_ACCESORepository  = new CONTROL_ACCESORepository (ConnectionString,DatabaseEngine);
			_control_MV_CalculoRepository  = new Control_MV_CalculoRepository (ConnectionString,DatabaseEngine);
			_cRM_MV_EVENTOSRepository  = new CRM_MV_EVENTOSRepository (ConnectionString,DatabaseEngine);
			_cRM_TA_EVENTOSRepository  = new CRM_TA_EVENTOSRepository (ConnectionString,DatabaseEngine);
			_dtpropertiesRepository  = new dtpropertiesRepository (ConnectionString,DatabaseEngine);
			_eM_MV_PESADAS_TRIGORepository  = new EM_MV_PESADAS_TRIGORepository (ConnectionString,DatabaseEngine);
			_eQ_COND_INTERFACESRepository  = new EQ_COND_INTERFACESRepository (ConnectionString,DatabaseEngine);
			_eQ_CONDIVA_IMPORTACIONRepository  = new EQ_CONDIVA_IMPORTACIONRepository (ConnectionString,DatabaseEngine);
			_eQ_CTA_INTERFACERepository  = new EQ_CTA_INTERFACERepository (ConnectionString,DatabaseEngine);
			_eQ_TC_INTERFACERepository  = new EQ_TC_INTERFACERepository (ConnectionString,DatabaseEngine);
			_gM_V_MV_PLANILLA_CABRepository  = new GM_V_MV_PLANILLA_CABRepository (ConnectionString,DatabaseEngine);
			_gM_V_MV_PLANILLA_DETALLERepository  = new GM_V_MV_PLANILLA_DETALLERepository (ConnectionString,DatabaseEngine);
			_l_MA_LicenciasRepository  = new L_MA_LicenciasRepository (ConnectionString,DatabaseEngine);
			_l_MA_LicenciasCategoriasRepository  = new L_MA_LicenciasCategoriasRepository (ConnectionString,DatabaseEngine);
			_l_MA_LICENCIASCtrolMedicoRepository  = new L_MA_LICENCIASCtrolMedicoRepository (ConnectionString,DatabaseEngine);
			_l_MA_LICENCIASDOCUMENTACIONRepository  = new L_MA_LICENCIASDOCUMENTACIONRepository (ConnectionString,DatabaseEngine);
			_l_MA_LICENCIASEXAMENESRepository  = new L_MA_LICENCIASEXAMENESRepository (ConnectionString,DatabaseEngine);
			_l_MV_LicenciasRepository  = new L_MV_LicenciasRepository (ConnectionString,DatabaseEngine);
			_l_MV_RuitRepository  = new L_MV_RuitRepository (ConnectionString,DatabaseEngine);
			_l_TA_CategoriasRepository  = new L_TA_CategoriasRepository (ConnectionString,DatabaseEngine);
			_l_TA_ClaseLicenciaRepository  = new L_TA_ClaseLicenciaRepository (ConnectionString,DatabaseEngine);
			_l_TA_ControlMedicoRepository  = new L_TA_ControlMedicoRepository (ConnectionString,DatabaseEngine);
			_l_TA_DocumentacionRepository  = new L_TA_DocumentacionRepository (ConnectionString,DatabaseEngine);
			_l_TA_ExamenesRepository  = new L_TA_ExamenesRepository (ConnectionString,DatabaseEngine);
			_l_TA_LocalidadesRepository  = new L_TA_LocalidadesRepository (ConnectionString,DatabaseEngine);
			_l_TA_PartidosRepository  = new L_TA_PartidosRepository (ConnectionString,DatabaseEngine);
			_l_TA_TipoDocRepository  = new L_TA_TipoDocRepository (ConnectionString,DatabaseEngine);
			_logDbRepository  = new LogDbRepository (ConnectionString,DatabaseEngine);
			_mA_ARBOL_OPERATIVORepository  = new MA_ARBOL_OPERATIVORepository (ConnectionString,DatabaseEngine);
			_mA_BIENESRepository  = new MA_BIENESRepository (ConnectionString,DatabaseEngine);
			_mA_BIENES_NOVEDADESRepository  = new MA_BIENES_NOVEDADESRepository (ConnectionString,DatabaseEngine);
			_mA_CalendarioRepository  = new MA_CalendarioRepository (ConnectionString,DatabaseEngine);
			_mA_CASH_CONTROLRepository  = new MA_CASH_CONTROLRepository (ConnectionString,DatabaseEngine);
			_mA_CASH_CTAS_PRINCIPALESRepository  = new MA_CASH_CTAS_PRINCIPALESRepository (ConnectionString,DatabaseEngine);
			_mA_CASH_DETALLERepository  = new MA_CASH_DETALLERepository (ConnectionString,DatabaseEngine);
			_mA_CASH_FLOWRepository  = new MA_CASH_FLOWRepository (ConnectionString,DatabaseEngine);
			_mA_CASH_GRUPORepository  = new MA_CASH_GRUPORepository (ConnectionString,DatabaseEngine);
			_mA_CASH_PROYECTADORepository  = new MA_CASH_PROYECTADORepository (ConnectionString,DatabaseEngine);
			_mA_CASHPFERepository  = new MA_CASHPFERepository (ConnectionString,DatabaseEngine);
			_mA_CASHPFE_DETALLERepository  = new MA_CASHPFE_DETALLERepository (ConnectionString,DatabaseEngine);
			_mA_CASHPFE_GRUPORepository  = new MA_CASHPFE_GRUPORepository (ConnectionString,DatabaseEngine);
			_mA_CASHPFE_PROYECTADORepository  = new MA_CASHPFE_PROYECTADORepository (ConnectionString,DatabaseEngine);
			_mA_ChoferesRepository  = new MA_ChoferesRepository (ConnectionString,DatabaseEngine);
			_mA_CONTACTOSRepository  = new MA_CONTACTOSRepository (ConnectionString,DatabaseEngine);
			_mA_CONTACTOS_ADICRepository  = new MA_CONTACTOS_ADICRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTASRepository  = new MA_CUENTASRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_ALERTASRepository  = new MA_CUENTAS_ALERTASRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository  = new MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_CTAS_BANCARIASRepository  = new MA_CUENTAS_CTAS_BANCARIASRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_DATOS_LABORALESRepository  = new MA_CUENTAS_DATOS_LABORALESRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_DESCUENTO_RUBROSRepository  = new MA_CUENTAS_DESCUENTO_RUBROSRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_DIRECCIONESRepository  = new MA_CUENTAS_DIRECCIONESRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_ENCOMIENDASRepository  = new MA_CUENTAS_ENCOMIENDASRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_ENCOMIENDAS_CANTRepository  = new MA_CUENTAS_ENCOMIENDAS_CANTRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_FACTURACION_RECURRENTERepository  = new MA_CUENTAS_FACTURACION_RECURRENTERepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_FAMILIASRepository  = new MA_CUENTAS_FAMILIASRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_INFO_ADICIONALRepository  = new MA_CUENTAS_INFO_ADICIONALRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_INFORMESRepository  = new MA_CUENTAS_INFORMESRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_RUTEO_VENDEDORRepository  = new MA_CUENTAS_RUTEO_VENDEDORRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_SUCURSALESRepository  = new MA_CUENTAS_SUCURSALESRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTAS_USUARIOSRepository  = new MA_CUENTAS_USUARIOSRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTASADICRepository  = new MA_CUENTASADICRepository (ConnectionString,DatabaseEngine);
			_mA_CUENTASCCOSTORepository  = new MA_CUENTASCCOSTORepository (ConnectionString,DatabaseEngine);
			_mA_ESTADISTICACTARepository  = new MA_ESTADISTICACTARepository (ConnectionString,DatabaseEngine);
			_mA_INDAJUSTERepository  = new MA_INDAJUSTERepository (ConnectionString,DatabaseEngine);
			_mA_MODELOSRepository  = new MA_MODELOSRepository (ConnectionString,DatabaseEngine);
			_mA_SUBDIARIOSRepository  = new MA_SUBDIARIOSRepository (ConnectionString,DatabaseEngine);
			_mA_SUBDIARIOSCOMPROBANTESRepository  = new MA_SUBDIARIOSCOMPROBANTESRepository (ConnectionString,DatabaseEngine);
			_mA_vehiculosRepository  = new MA_vehiculosRepository (ConnectionString,DatabaseEngine);
			_mV_AgendaRepository  = new MV_AgendaRepository (ConnectionString,DatabaseEngine);
			_mV_APLICACIONRepository  = new MV_APLICACIONRepository (ConnectionString,DatabaseEngine);
			_mV_ASIENTOSRepository  = new MV_ASIENTOSRepository (ConnectionString,DatabaseEngine);
			_mV_ASIENTOSCCOSTORepository  = new MV_ASIENTOSCCOSTORepository (ConnectionString,DatabaseEngine);
			_mV_BIENESRepository  = new MV_BIENESRepository (ConnectionString,DatabaseEngine);
			_mV_BIENES_DETALLERepository  = new MV_BIENES_DETALLERepository (ConnectionString,DatabaseEngine);
			_mV_CALCULO_BIENESRepository  = new MV_CALCULO_BIENESRepository (ConnectionString,DatabaseEngine);
			_mV_CONTROL_AS_RESRepository  = new MV_CONTROL_AS_RESRepository (ConnectionString,DatabaseEngine);
			_mV_EJERCICIOSRepository  = new MV_EJERCICIOSRepository (ConnectionString,DatabaseEngine);
			_mV_INVENTARIOSRepository  = new MV_INVENTARIOSRepository (ConnectionString,DatabaseEngine);
			_mV_INVENTARIOSCABRepository  = new MV_INVENTARIOSCABRepository (ConnectionString,DatabaseEngine);
			_mV_SALDOSRepository  = new MV_SALDOSRepository (ConnectionString,DatabaseEngine);
			_p_MA_ClientesRepository  = new P_MA_ClientesRepository (ConnectionString,DatabaseEngine);
			_p_MA_EmpresasRepository  = new P_MA_EmpresasRepository (ConnectionString,DatabaseEngine);
			_p_MA_FamiliarRepository  = new P_MA_FamiliarRepository (ConnectionString,DatabaseEngine);
			_p_MA_LegajosRepository  = new P_MA_LegajosRepository (ConnectionString,DatabaseEngine);
			_p_MA_PostulanteAuxiliarRepository  = new P_MA_PostulanteAuxiliarRepository (ConnectionString,DatabaseEngine);
			_p_MA_PostulantesRepository  = new P_MA_PostulantesRepository (ConnectionString,DatabaseEngine);
			_p_MA_Postulantes_ConocimientosRepository  = new P_MA_Postulantes_ConocimientosRepository (ConnectionString,DatabaseEngine);
			_p_MA_Postulantes_ExperienciaRepository  = new P_MA_Postulantes_ExperienciaRepository (ConnectionString,DatabaseEngine);
			_p_MA_Postulantes_IdiomasRepository  = new P_MA_Postulantes_IdiomasRepository (ConnectionString,DatabaseEngine);
			_p_MA_Postulantes_ObsRepository  = new P_MA_Postulantes_ObsRepository (ConnectionString,DatabaseEngine);
			_p_MA_Postulantes_TitulosRepository  = new P_MA_Postulantes_TitulosRepository (ConnectionString,DatabaseEngine);
			_p_MV_BusquedasRepository  = new P_MV_BusquedasRepository (ConnectionString,DatabaseEngine);
			_p_MV_CtrolHorariosRepository  = new P_MV_CtrolHorariosRepository (ConnectionString,DatabaseEngine);
			_p_MV_DeudoresRepository  = new P_MV_DeudoresRepository (ConnectionString,DatabaseEngine);
			_p_MV_EntrevistasRepository  = new P_MV_EntrevistasRepository (ConnectionString,DatabaseEngine);
			_p_MV_ReferenciasRepository  = new P_MV_ReferenciasRepository (ConnectionString,DatabaseEngine);
			_p_MV_SeguimientoRepository  = new P_MV_SeguimientoRepository (ConnectionString,DatabaseEngine);
			_p_MV_SolicitudRRHHRepository  = new P_MV_SolicitudRRHHRepository (ConnectionString,DatabaseEngine);
			_p_MV_SolicitudRRHH_ConocimientosRepository  = new P_MV_SolicitudRRHH_ConocimientosRepository (ConnectionString,DatabaseEngine);
			_p_MV_SolicitudRRHH_IdiomasRepository  = new P_MV_SolicitudRRHH_IdiomasRepository (ConnectionString,DatabaseEngine);
			_p_MV_SolicitudRRHH_TitulosRepository  = new P_MV_SolicitudRRHH_TitulosRepository (ConnectionString,DatabaseEngine);
			_p_TA_AreasRepository  = new P_TA_AreasRepository (ConnectionString,DatabaseEngine);
			_p_TA_CategorizacionRepository  = new P_TA_CategorizacionRepository (ConnectionString,DatabaseEngine);
			_p_TA_CentroMedicoRepository  = new P_TA_CentroMedicoRepository (ConnectionString,DatabaseEngine);
			_p_Ta_ConocimientosRepository  = new P_Ta_ConocimientosRepository (ConnectionString,DatabaseEngine);
			_p_TA_EstadoBusquedaRepository  = new P_TA_EstadoBusquedaRepository (ConnectionString,DatabaseEngine);
			_p_TA_EstadoCivilRepository  = new P_TA_EstadoCivilRepository (ConnectionString,DatabaseEngine);
			_p_TA_EstadoPostulanteRepository  = new P_TA_EstadoPostulanteRepository (ConnectionString,DatabaseEngine);
			_p_TA_FormasDePagoRepository  = new P_TA_FormasDePagoRepository (ConnectionString,DatabaseEngine);
			_p_TA_FuncionesRepository  = new P_TA_FuncionesRepository (ConnectionString,DatabaseEngine);
			_p_TA_GruposRepository  = new P_TA_GruposRepository (ConnectionString,DatabaseEngine);
			_p_TA_IdiomasRepository  = new P_TA_IdiomasRepository (ConnectionString,DatabaseEngine);
			_p_TA_MotivoEgresoRepository  = new P_TA_MotivoEgresoRepository (ConnectionString,DatabaseEngine);
			_p_TA_NivelEstudioRepository  = new P_TA_NivelEstudioRepository (ConnectionString,DatabaseEngine);
			_p_TA_ObraSocialRepository  = new P_TA_ObraSocialRepository (ConnectionString,DatabaseEngine);
			_p_TA_ParentescoRepository  = new P_TA_ParentescoRepository (ConnectionString,DatabaseEngine);
			_p_TA_SindicatosRepository  = new P_TA_SindicatosRepository (ConnectionString,DatabaseEngine);
			_p_TA_TipoPuestoRepository  = new P_TA_TipoPuestoRepository (ConnectionString,DatabaseEngine);
			_p_TA_TitulosRepository  = new P_TA_TitulosRepository (ConnectionString,DatabaseEngine);
			_p_TA_ZonaResidenciaRepository  = new P_TA_ZonaResidenciaRepository (ConnectionString,DatabaseEngine);
			_pRUEBAESTADISTICARepository  = new PRUEBAESTADISTICARepository (ConnectionString,DatabaseEngine);
			_rMA_ESTADOSRepository  = new RMA_ESTADOSRepository (ConnectionString,DatabaseEngine);
			_rMA_MOTIVOSRepository  = new RMA_MOTIVOSRepository (ConnectionString,DatabaseEngine);
			_rMA_TRAZABILIDAD_ARTICULOSRepository  = new RMA_TRAZABILIDAD_ARTICULOSRepository (ConnectionString,DatabaseEngine);
			_s_TA_EQUIVRepository  = new S_TA_EQUIVRepository (ConnectionString,DatabaseEngine);
			_t_VEHICULOS_NOVEDADESRepository  = new T_VEHICULOS_NOVEDADESRepository (ConnectionString,DatabaseEngine);
			_tA_AGRUPCUENTASRepository  = new TA_AGRUPCUENTASRepository (ConnectionString,DatabaseEngine);
			_tA_AGRUPCUENTAS_DETALLERepository  = new TA_AGRUPCUENTAS_DETALLERepository (ConnectionString,DatabaseEngine);
			_ta_ArchivoLegalRepository  = new Ta_ArchivoLegalRepository (ConnectionString,DatabaseEngine);
			_tA_AUDITORIARepository  = new TA_AUDITORIARepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_CCOSTORepository  = new TA_BIENES_CCOSTORepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_CLASESRepository  = new TA_BIENES_CLASESRepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_ESTADOSRepository  = new TA_BIENES_ESTADOSRepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_MARCASRepository  = new TA_BIENES_MARCASRepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_MOTIVOSRepository  = new TA_BIENES_MOTIVOSRepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_PROPIETARIOSRepository  = new TA_BIENES_PROPIETARIOSRepository (ConnectionString,DatabaseEngine);
			_tA_BIENES_TIPOSRepository  = new TA_BIENES_TIPOSRepository (ConnectionString,DatabaseEngine);
			_tA_CCOSTORepository  = new TA_CCOSTORepository (ConnectionString,DatabaseEngine);
			_tA_COMPROBANTESRepository  = new TA_COMPROBANTESRepository (ConnectionString,DatabaseEngine);
			_tA_CONDIVARepository  = new TA_CONDIVARepository (ConnectionString,DatabaseEngine);
			_tA_CONFIGURACIONRepository  = new TA_CONFIGURACIONRepository (ConnectionString,DatabaseEngine);
			_tA_COTIZACIONRepository  = new TA_COTIZACIONRepository (ConnectionString,DatabaseEngine);
			_tA_CUENTAS_COMPROBANTESRepository  = new TA_CUENTAS_COMPROBANTESRepository (ConnectionString,DatabaseEngine);
			_tA_CUENTASIVARepository  = new TA_CUENTASIVARepository (ConnectionString,DatabaseEngine);
			_tA_DistLocalidadesRepository  = new TA_DistLocalidadesRepository (ConnectionString,DatabaseEngine);
			_tA_ESTADOSRepository  = new TA_ESTADOSRepository (ConnectionString,DatabaseEngine);
			_tA_IMPORTACUENTASRepository  = new TA_IMPORTACUENTASRepository (ConnectionString,DatabaseEngine);
			_tA_IMPORTACUENTASDETALLERepository  = new TA_IMPORTACUENTASDETALLERepository (ConnectionString,DatabaseEngine);
			_tA_INTERFACESRepository  = new TA_INTERFACESRepository (ConnectionString,DatabaseEngine);
			_tA_INTERFACES_DETALLERepository  = new TA_INTERFACES_DETALLERepository (ConnectionString,DatabaseEngine);
			_tA_LOGOSRepository  = new TA_LOGOSRepository (ConnectionString,DatabaseEngine);
			_tA_MARCASRepository  = new TA_MARCASRepository (ConnectionString,DatabaseEngine);
			_tA_MENURepository  = new TA_MENURepository (ConnectionString,DatabaseEngine);
			_tA_MONEDASRepository  = new TA_MONEDASRepository (ConnectionString,DatabaseEngine);
			_ta_NumArchivoLegalRepository  = new Ta_NumArchivoLegalRepository (ConnectionString,DatabaseEngine);
			_tA_PAISESRepository  = new TA_PAISESRepository (ConnectionString,DatabaseEngine);
			_tA_PUBLICACIONESRepository  = new TA_PUBLICACIONESRepository (ConnectionString,DatabaseEngine);
			_tA_RANGOS_DATOS_ADICRepository  = new TA_RANGOS_DATOS_ADICRepository (ConnectionString,DatabaseEngine);
			_tA_REPORTESRepository  = new TA_REPORTESRepository (ConnectionString,DatabaseEngine);
			_tA_TAREASRepository  = new TA_TAREASRepository (ConnectionString,DatabaseEngine);
			_tA_TERMINALESRepository  = new TA_TERMINALESRepository (ConnectionString,DatabaseEngine);
			_tA_TIPODOCUMENTORepository  = new TA_TIPODOCUMENTORepository (ConnectionString,DatabaseEngine);
			_tA_TIPOVEHICULORepository  = new TA_TIPOVEHICULORepository (ConnectionString,DatabaseEngine);
			_tA_TITCOPIADORESRepository  = new TA_TITCOPIADORESRepository (ConnectionString,DatabaseEngine);
			_tA_USUARIOSRepository  = new TA_USUARIOSRepository (ConnectionString,DatabaseEngine);
			_tA_VISTASRepository  = new TA_VISTASRepository (ConnectionString,DatabaseEngine);
			_tESTIGO_EXPORTACIONRepository  = new TESTIGO_EXPORTACIONRepository (ConnectionString,DatabaseEngine);
			_tESTIGO_RECEPCIONRepository  = new TESTIGO_RECEPCIONRepository (ConnectionString,DatabaseEngine);
			_tMP_BusquedaPrecioRepository  = new TMP_BusquedaPrecioRepository (ConnectionString,DatabaseEngine);
			_uTL_TA_VENTANASRepository  = new UTL_TA_VENTANASRepository (ConnectionString,DatabaseEngine);
			_v_CRM_MV_CPTERepository  = new V_CRM_MV_CPTERepository (ConnectionString,DatabaseEngine);
			_v_CRM_TA_ACCIONESRepository  = new V_CRM_TA_ACCIONESRepository (ConnectionString,DatabaseEngine);
			_v_CRM_TA_ESTADOSRepository  = new V_CRM_TA_ESTADOSRepository (ConnectionString,DatabaseEngine);
			_v_FIDELIZACIONRepository  = new V_FIDELIZACIONRepository (ConnectionString,DatabaseEngine);
			_v_FIDELIZACION_ARTICULOSRepository  = new V_FIDELIZACION_ARTICULOSRepository (ConnectionString,DatabaseEngine);
			_v_FIDELIZACION_MV_PUNTOSRepository  = new V_FIDELIZACION_MV_PUNTOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_AERONAVESRepository  = new V_MA_AERONAVESRepository (ConnectionString,DatabaseEngine);
			_v_MA_AERONAVES_COMPONENTESRepository  = new V_MA_AERONAVES_COMPONENTESRepository (ConnectionString,DatabaseEngine);
			_v_MA_AERONAVES_DOCUMENTOSRepository  = new V_MA_AERONAVES_DOCUMENTOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_ARTICULOSRepository  = new V_MA_ARTICULOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_ARTICULOS_ALERTASRepository  = new V_MA_ARTICULOS_ALERTASRepository (ConnectionString,DatabaseEngine);
			_v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository  = new V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository  = new V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_ARTICULOS_SINONIMOSRepository  = new V_MA_ARTICULOS_SINONIMOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_EXPRESOSRepository  = new V_MA_EXPRESOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_INSUMOSRepository  = new V_MA_INSUMOSRepository (ConnectionString,DatabaseEngine);
			_v_MA_POSICRepository  = new V_MA_POSICRepository (ConnectionString,DatabaseEngine);
			_v_MA_PreciosRepository  = new V_MA_PreciosRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteRepository  = new V_MV_CpteRepository (ConnectionString,DatabaseEngine);
			_v_MV_CPTE_OBSERVRepository  = new V_MV_CPTE_OBSERVRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteAccionesRepository  = new V_MV_CpteAccionesRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteDocRepository  = new V_MV_CpteDocRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteEnComisionRepository  = new V_MV_CpteEnComisionRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteInsumosRepository  = new V_MV_CpteInsumosRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteTareasRepository  = new V_MV_CpteTareasRepository (ConnectionString,DatabaseEngine);
			_v_MV_CpteTercerosRepository  = new V_MV_CpteTercerosRepository (ConnectionString,DatabaseEngine);
			_v_mv_crealesRepository  = new v_mv_crealesRepository (ConnectionString,DatabaseEngine);
			_v_mv_creales_AplicacionRepository  = new v_mv_creales_AplicacionRepository (ConnectionString,DatabaseEngine);
			_v_MV_CUOTASRepository  = new V_MV_CUOTASRepository (ConnectionString,DatabaseEngine);
			_v_MV_DiariosRepository  = new V_MV_DiariosRepository (ConnectionString,DatabaseEngine);
			_v_MV_PreciosHisRepository  = new V_MV_PreciosHisRepository (ConnectionString,DatabaseEngine);
			_v_MV_SOLICITUD_ARTICULOSRepository  = new V_MV_SOLICITUD_ARTICULOSRepository (ConnectionString,DatabaseEngine);
			_v_MV_StockRepository  = new V_MV_StockRepository (ConnectionString,DatabaseEngine);
			_v_TA_ALERTAS_STOCKRepository  = new V_TA_ALERTAS_STOCKRepository (ConnectionString,DatabaseEngine);
			_v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository  = new V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_ATRIBUTOS_PROD_ARTICULOSRepository  = new V_TA_ATRIBUTOS_PROD_ARTICULOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_BancosRepository  = new V_TA_BancosRepository (ConnectionString,DatabaseEngine);
			_v_TA_BONIFICACIONES_COMPRASRepository  = new V_TA_BONIFICACIONES_COMPRASRepository (ConnectionString,DatabaseEngine);
			_v_Ta_CajasRepository  = new V_Ta_CajasRepository (ConnectionString,DatabaseEngine);
			_v_TA_CATALOGOS_HTMRepository  = new V_TA_CATALOGOS_HTMRepository (ConnectionString,DatabaseEngine);
			_v_TA_CATALOGOS_HTM_DETALLERepository  = new V_TA_CATALOGOS_HTM_DETALLERepository (ConnectionString,DatabaseEngine);
			_v_TA_CategoriaRepository  = new V_TA_CategoriaRepository (ConnectionString,DatabaseEngine);
			_v_TA_CLASIFICACION_CREDITICIARepository  = new V_TA_CLASIFICACION_CREDITICIARepository (ConnectionString,DatabaseEngine);
			_v_TA_COMBOSRepository  = new V_TA_COMBOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_COMBOS_DETALLERepository  = new V_TA_COMBOS_DETALLERepository (ConnectionString,DatabaseEngine);
			_v_TA_CONFIG_IMPRESION_CPTESRepository  = new V_TA_CONFIG_IMPRESION_CPTESRepository (ConnectionString,DatabaseEngine);
			_v_TA_Cpra_VtaRepository  = new V_TA_Cpra_VtaRepository (ConnectionString,DatabaseEngine);
			_v_TA_CpteRepository  = new V_TA_CpteRepository (ConnectionString,DatabaseEngine);
			_v_TA_CTRL_CHEQUERASRepository  = new V_TA_CTRL_CHEQUERASRepository (ConnectionString,DatabaseEngine);
			_v_TA_CuentasComisionRepository  = new V_TA_CuentasComisionRepository (ConnectionString,DatabaseEngine);
			_v_TA_DEPOSITORepository  = new V_TA_DEPOSITORepository (ConnectionString,DatabaseEngine);
			_v_TA_DEPOSITO_MMRepository  = new V_TA_DEPOSITO_MMRepository (ConnectionString,DatabaseEngine);
			_v_TA_DESTINORepository  = new V_TA_DESTINORepository (ConnectionString,DatabaseEngine);
			_v_TA_ESCALARETENCIONESRepository  = new V_TA_ESCALARETENCIONESRepository (ConnectionString,DatabaseEngine);
			_v_TA_ESTADO_VISITASRepository  = new V_TA_ESTADO_VISITASRepository (ConnectionString,DatabaseEngine);
			_v_TA_FAMILIASRepository  = new V_TA_FAMILIASRepository (ConnectionString,DatabaseEngine);
			_v_TA_GARANTIASRepository  = new V_TA_GARANTIASRepository (ConnectionString,DatabaseEngine);
			_v_TA_Input_ComprasRepository  = new V_TA_Input_ComprasRepository (ConnectionString,DatabaseEngine);
			_v_TA_Input_VentasRepository  = new V_TA_Input_VentasRepository (ConnectionString,DatabaseEngine);
			_v_TA_INTERFACESRepository  = new V_TA_INTERFACESRepository (ConnectionString,DatabaseEngine);
			_v_TA_Interfaces_asignacionCamposRepository  = new V_TA_Interfaces_asignacionCamposRepository (ConnectionString,DatabaseEngine);
			_v_TA_Interfaces_DetalleRepository  = new V_TA_Interfaces_DetalleRepository (ConnectionString,DatabaseEngine);
			_v_TA_Interfaces_EquivalenciaRepository  = new V_TA_Interfaces_EquivalenciaRepository (ConnectionString,DatabaseEngine);
			_v_TA_INTERFACES_FILTROSRepository  = new V_TA_INTERFACES_FILTROSRepository (ConnectionString,DatabaseEngine);
			_v_TA_MOTIVO_AJUSTESRepository  = new V_TA_MOTIVO_AJUSTESRepository (ConnectionString,DatabaseEngine);
			_v_TA_MOTIVO_BAJA_CUENTASRepository  = new V_TA_MOTIVO_BAJA_CUENTASRepository (ConnectionString,DatabaseEngine);
			_v_TA_MotivoCpraRepository  = new V_TA_MotivoCpraRepository (ConnectionString,DatabaseEngine);
			_v_TA_MOTIVOS_ANULACIONESRepository  = new V_TA_MOTIVOS_ANULACIONESRepository (ConnectionString,DatabaseEngine);
			_v_TA_MotivoStockRepository  = new V_TA_MotivoStockRepository (ConnectionString,DatabaseEngine);
			_v_TA_MotivoVtaRepository  = new V_TA_MotivoVtaRepository (ConnectionString,DatabaseEngine);
			_v_TA_OrigenRepository  = new V_TA_OrigenRepository (ConnectionString,DatabaseEngine);
			_v_TA_PercepcionRepository  = new V_TA_PercepcionRepository (ConnectionString,DatabaseEngine);
			_v_TA_PLANTILLA_FORMULARIOSRepository  = new V_TA_PLANTILLA_FORMULARIOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_PoliticaPreciosRepository  = new V_TA_PoliticaPreciosRepository (ConnectionString,DatabaseEngine);
			_v_TA_PROCESOS_PRODUCTIVOSRepository  = new V_TA_PROCESOS_PRODUCTIVOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_REPORTES_PERSONALIZADOSRepository  = new V_TA_REPORTES_PERSONALIZADOSRepository (ConnectionString,DatabaseEngine);
			_v_TA_REPORTES_PERSONALIZADOS_DETALLERepository  = new V_TA_REPORTES_PERSONALIZADOS_DETALLERepository (ConnectionString,DatabaseEngine);
			_v_TA_RETENCIONESRepository  = new V_TA_RETENCIONESRepository (ConnectionString,DatabaseEngine);
			_v_TA_RubrosRepository  = new V_TA_RubrosRepository (ConnectionString,DatabaseEngine);
			_v_TA_SECTORESRepository  = new V_TA_SECTORESRepository (ConnectionString,DatabaseEngine);
			_v_TA_STATUS_NPRepository  = new V_TA_STATUS_NPRepository (ConnectionString,DatabaseEngine);
			_v_TA_STATUS_OPRepository  = new V_TA_STATUS_OPRepository (ConnectionString,DatabaseEngine);
			_v_TA_SUCURSALESRepository  = new V_TA_SUCURSALESRepository (ConnectionString,DatabaseEngine);
			_v_TA_TareasRepository  = new V_TA_TareasRepository (ConnectionString,DatabaseEngine);
			_v_TA_TecnicosRepository  = new V_TA_TecnicosRepository (ConnectionString,DatabaseEngine);
			_v_TA_TEMPORADASRepository  = new V_TA_TEMPORADASRepository (ConnectionString,DatabaseEngine);
			_v_TA_TipoArticuloRepository  = new V_TA_TipoArticuloRepository (ConnectionString,DatabaseEngine);
			_v_TA_UnidadRepository  = new V_TA_UnidadRepository (ConnectionString,DatabaseEngine);
			_v_TA_VENDEDORESRepository  = new V_TA_VENDEDORESRepository (ConnectionString,DatabaseEngine);
			_v_TA_VENDEDORES_ALERTASRepository  = new V_TA_VENDEDORES_ALERTASRepository (ConnectionString,DatabaseEngine);
			_v_TA_ZONASRepository  = new V_TA_ZONASRepository (ConnectionString,DatabaseEngine);

			//ViewManagers
			_aUX_MV_CPTE_COBRANZASViewManager  = new AUX_MV_CPTE_COBRANZASViewManager (ConnectionString,DatabaseEngine);
			_aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager  = new AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager (ConnectionString,DatabaseEngine);
			_aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager  = new AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager (ConnectionString,DatabaseEngine);
			_auxObtieneNetoViewManager  = new AuxObtieneNetoViewManager (ConnectionString,DatabaseEngine);
			_c_BusquedaPreciosProveedorDtoCpraViewManager  = new C_BusquedaPreciosProveedorDtoCpraViewManager (ConnectionString,DatabaseEngine);
			_c_MV_CPTE_RANKING_CONSUMOViewManager  = new C_MV_CPTE_RANKING_CONSUMOViewManager (ConnectionString,DatabaseEngine);
			_c_RemitosConCobranzasViewManager  = new C_RemitosConCobranzasViewManager (ConnectionString,DatabaseEngine);
			_c_RemitosFacturadosViewManager  = new C_RemitosFacturadosViewManager (ConnectionString,DatabaseEngine);
			_c_RemitosPendientesViewManager  = new c_RemitosPendientesViewManager (ConnectionString,DatabaseEngine);
			_c_RemitosPendientesSinProveedorViewManager  = new C_RemitosPendientesSinProveedorViewManager (ConnectionString,DatabaseEngine);
			_c_RemitosSinAplicacionViewManager  = new C_RemitosSinAplicacionViewManager (ConnectionString,DatabaseEngine);
			_chequesFirmadosNoConciliadosViewManager  = new ChequesFirmadosNoConciliadosViewManager (ConnectionString,DatabaseEngine);
			_cO_AplicacionOCViewManager  = new CO_AplicacionOCViewManager (ConnectionString,DatabaseEngine);
			_cO_CPTES_CREDITOS_PENDIENTESViewManager  = new CO_CPTES_CREDITOS_PENDIENTESViewManager (ConnectionString,DatabaseEngine);
			_cO_CPTES_IMPAGOSViewManager  = new CO_CPTES_IMPAGOSViewManager (ConnectionString,DatabaseEngine);
			_cO_FaltantesOCViewManager  = new CO_FaltantesOCViewManager (ConnectionString,DatabaseEngine);
			_cO_FCCore_PendientesViewManager  = new CO_FCCore_PendientesViewManager (ConnectionString,DatabaseEngine);
			_cO_OCompraPendientesViewManager  = new CO_OCompraPendientesViewManager (ConnectionString,DatabaseEngine);
			_cO_OCompraPendientes_DetalleViewManager  = new CO_OCompraPendientes_DetalleViewManager (ConnectionString,DatabaseEngine);
			_gM_PLANILLASViewManager  = new GM_PLANILLASViewManager (ConnectionString,DatabaseEngine);
			_libroIvaComprasViewManager  = new LibroIvaComprasViewManager (ConnectionString,DatabaseEngine);
			_libroIvaVentasViewManager  = new LibroIvaVentasViewManager (ConnectionString,DatabaseEngine);
			_libroIvaVentasDirecto_ConsignadoViewManager  = new LibroIvaVentasDirecto_ConsignadoViewManager (ConnectionString,DatabaseEngine);
			_libroIvaVentasPorPeriodoViewManager  = new LibroIvaVentasPorPeriodoViewManager (ConnectionString,DatabaseEngine);
			_libroIvaVentasResumenViewManager  = new LibroIvaVentasResumenViewManager (ConnectionString,DatabaseEngine);
			_nW_DOCUMENTADORViewManager  = new NW_DOCUMENTADORViewManager (ConnectionString,DatabaseEngine);
			_p_AUX_LEGAJOSViewManager  = new P_AUX_LEGAJOSViewManager (ConnectionString,DatabaseEngine);
			_p_EntrevistasViewManager  = new P_EntrevistasViewManager (ConnectionString,DatabaseEngine);
			_p_ENTREVISTASEVALUACIONESViewManager  = new P_ENTREVISTASEVALUACIONESViewManager (ConnectionString,DatabaseEngine);
			_p_EntrevistasFHViewManager  = new P_EntrevistasFHViewManager (ConnectionString,DatabaseEngine);
			_p_EntrevistasPendientesViewManager  = new P_EntrevistasPendientesViewManager (ConnectionString,DatabaseEngine);
			_p_EntrevistasPendientesFhViewManager  = new P_EntrevistasPendientesFhViewManager (ConnectionString,DatabaseEngine);
			_p_EvaluacionesViewManager  = new P_EvaluacionesViewManager (ConnectionString,DatabaseEngine);
			_p_EvaluacionesPendientesViewManager  = new P_EvaluacionesPendientesViewManager (ConnectionString,DatabaseEngine);
			_p_SaldosClientesViewManager  = new P_SaldosClientesViewManager (ConnectionString,DatabaseEngine);
			_p_SaldosClientesBusquedasViewManager  = new P_SaldosClientesBusquedasViewManager (ConnectionString,DatabaseEngine);
			_p_Sind_CategoriasViewManager  = new P_Sind_CategoriasViewManager (ConnectionString,DatabaseEngine);
			_p_SindCatCargosViewManager  = new P_SindCatCargosViewManager (ConnectionString,DatabaseEngine);
			_p_SindicatosViewManager  = new P_SindicatosViewManager (ConnectionString,DatabaseEngine);
			_p_SolucitudesViewManager  = new P_SolucitudesViewManager (ConnectionString,DatabaseEngine);
			_p_SolucitudesAFinalizarViewManager  = new P_SolucitudesAFinalizarViewManager (ConnectionString,DatabaseEngine);
			_p_SolucitudesPostulantesViewManager  = new P_SolucitudesPostulantesViewManager (ConnectionString,DatabaseEngine);
			_p_TodasLasSolicitudesViewManager  = new P_TodasLasSolicitudesViewManager (ConnectionString,DatabaseEngine);
			_p_TodasLasSolicitudesPostViewManager  = new P_TodasLasSolicitudesPostViewManager (ConnectionString,DatabaseEngine);
			_p_TodasLasSolicitudesPostulantesViewManager  = new P_TodasLasSolicitudesPostulantesViewManager (ConnectionString,DatabaseEngine);
			_rANKING_CONSUMOViewManager  = new RANKING_CONSUMOViewManager (ConnectionString,DatabaseEngine);
			_stk_Ma_ArticulosViewManager  = new Stk_Ma_ArticulosViewManager (ConnectionString,DatabaseEngine);
			_sTK_PuntoReposicionViewManager  = new STK_PuntoReposicionViewManager (ConnectionString,DatabaseEngine);
			_sTK_SALDOS_ART_CON_TROPAViewManager  = new STK_SALDOS_ART_CON_TROPAViewManager (ConnectionString,DatabaseEngine);
			_sTK_SALDOS_SLViewManager  = new STK_SALDOS_SLViewManager (ConnectionString,DatabaseEngine);
			_sTK_SALDOS_UnidadesViewManager  = new STK_SALDOS_UnidadesViewManager (ConnectionString,DatabaseEngine);
			_sTK_SERIES_Y_LOTESViewManager  = new STK_SERIES_Y_LOTESViewManager (ConnectionString,DatabaseEngine);
			_sTK_STOCK_EQUIVViewManager  = new STK_STOCK_EQUIVViewManager (ConnectionString,DatabaseEngine);
			_sW_DOCUMENTADORViewManager  = new SW_DOCUMENTADORViewManager (ConnectionString,DatabaseEngine);
			_sW_TABLAS_CON_CAMPOSViewManager  = new SW_TABLAS_CON_CAMPOSViewManager (ConnectionString,DatabaseEngine);
			_sW_TABLAS_SISTEMAViewManager  = new SW_TABLAS_SISTEMAViewManager (ConnectionString,DatabaseEngine);
			_tmp_cuotasViewManager  = new tmp_cuotasViewManager (ConnectionString,DatabaseEngine);
			_v_Aplicacion_OrdenDePagoViewManager  = new V_Aplicacion_OrdenDePagoViewManager (ConnectionString,DatabaseEngine);
			_v_AsientosCCostoViewManager  = new V_AsientosCCostoViewManager (ConnectionString,DatabaseEngine);
			_v_chequesconciliadosViewManager  = new v_chequesconciliadosViewManager (ConnectionString,DatabaseEngine);
			_v_ChequesEnCarteraViewManager  = new V_ChequesEnCarteraViewManager (ConnectionString,DatabaseEngine);
			_v_ChequesEntregadosViewManager  = new V_ChequesEntregadosViewManager (ConnectionString,DatabaseEngine);
			_v_ChequesFirmadosViewManager  = new V_ChequesFirmadosViewManager (ConnectionString,DatabaseEngine);
			_v_ChequesFirmadosNoConciliadosViewManager  = new V_ChequesFirmadosNoConciliadosViewManager (ConnectionString,DatabaseEngine);
			_v_ChequesRecibidosViewManager  = new V_ChequesRecibidosViewManager (ConnectionString,DatabaseEngine);
			_v_COBRANZASPORUSUARIOViewManager  = new V_COBRANZASPORUSUARIOViewManager (ConnectionString,DatabaseEngine);
			_v_ConsultaDeRubroTipoProveedorViewManager  = new V_ConsultaDeRubroTipoProveedorViewManager (ConnectionString,DatabaseEngine);
			_v_ConsultaDeRubroTipoProveerdorArticulosViewManager  = new V_ConsultaDeRubroTipoProveerdorArticulosViewManager (ConnectionString,DatabaseEngine);
			_v_EstadoBancarioViewManager  = new V_EstadoBancarioViewManager (ConnectionString,DatabaseEngine);
			_v_ImportesAplicadosViewManager  = new V_ImportesAplicadosViewManager (ConnectionString,DatabaseEngine);
			_v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager  = new V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager (ConnectionString,DatabaseEngine);
			_v_mv_CargosAplicadosViewManager  = new v_mv_CargosAplicadosViewManager (ConnectionString,DatabaseEngine);
			_v_NP_PendientesViewManager  = new V_NP_PendientesViewManager (ConnectionString,DatabaseEngine);
			_v_NP_PENDIENTES_COMPROMETIDOViewManager  = new V_NP_PENDIENTES_COMPROMETIDOViewManager (ConnectionString,DatabaseEngine);
			_v_NP_PENDIENTES2ViewManager  = new V_NP_PENDIENTES2ViewManager (ConnectionString,DatabaseEngine);
			_v_OF_PENDIENTESViewManager  = new V_OF_PENDIENTESViewManager (ConnectionString,DatabaseEngine);
			_v_OT_PendientesViewManager  = new V_OT_PendientesViewManager (ConnectionString,DatabaseEngine);
			_v_PR_PendientesViewManager  = new V_PR_PendientesViewManager (ConnectionString,DatabaseEngine);
			_v_RemitosConCobranzasViewManager  = new V_RemitosConCobranzasViewManager (ConnectionString,DatabaseEngine);
			_v_RemitosFacturadosViewManager  = new V_RemitosFacturadosViewManager (ConnectionString,DatabaseEngine);
			_v_RemitosPendientesViewManager  = new V_RemitosPendientesViewManager (ConnectionString,DatabaseEngine);
			_v_RemitosSinAplicacionViewManager  = new V_RemitosSinAplicacionViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_CREDITOS_PENDIENTESViewManager  = new VE_CPTES_CREDITOS_PENDIENTESViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager  = new VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_IMPAGOSViewManager  = new VE_CPTES_IMPAGOSViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager  = new VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_SALDOSViewManager  = new VE_CPTES_SALDOSViewManager (ConnectionString,DatabaseEngine);
			_vE_CPTES_SALDOS_HABERViewManager  = new VE_CPTES_SALDOS_HABERViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOAPLICACIONViewManager  = new VE_SALDOAPLICACIONViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOAPLICACION_HABERViewManager  = new VE_SALDOAPLICACION_HABERViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSCTAViewManager  = new VE_SALDOSCTAViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSCTA_DEBEViewManager  = new VE_SALDOSCTA_DEBEViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSCTA_HABERViewManager  = new VE_SALDOSCTA_HABERViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSVDORViewManager  = new VE_SALDOSVDORViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSVDOR_DEBEViewManager  = new VE_SALDOSVDOR_DEBEViewManager (ConnectionString,DatabaseEngine);
			_vE_SALDOSVDOR_HABERViewManager  = new VE_SALDOSVDOR_HABERViewManager (ConnectionString,DatabaseEngine);
			_vT_C_MV_INSUMOS_APLICACIONViewManager  = new VT_C_MV_INSUMOS_APLICACIONViewManager (ConnectionString,DatabaseEngine);
			_vt_ClientesViewManager  = new Vt_ClientesViewManager (ConnectionString,DatabaseEngine);
			_vT_CO_CPTE_DiferidoViewManager  = new VT_CO_CPTE_DiferidoViewManager (ConnectionString,DatabaseEngine);
			_vT_COBRANZASViewManager  = new VT_COBRANZASViewManager (ConnectionString,DatabaseEngine);
			_vT_CPTE_DiferidoViewManager  = new VT_CPTE_DiferidoViewManager (ConnectionString,DatabaseEngine);
			_vT_DEPOSITO_MMViewManager  = new VT_DEPOSITO_MMViewManager (ConnectionString,DatabaseEngine);
			_vT_DEPOSITO_MM_STOCKViewManager  = new VT_DEPOSITO_MM_STOCKViewManager (ConnectionString,DatabaseEngine);
			_vT_ESTADISTICA_CLIENTESViewManager  = new VT_ESTADISTICA_CLIENTESViewManager (ConnectionString,DatabaseEngine);
			_vT_ESTADISTICA_CLIENTES_COBRANZASViewManager  = new VT_ESTADISTICA_CLIENTES_COBRANZASViewManager (ConnectionString,DatabaseEngine);
			_vT_ESTADISTICA_CLIENTES_ENTREGASViewManager  = new VT_ESTADISTICA_CLIENTES_ENTREGASViewManager (ConnectionString,DatabaseEngine);
			_vT_MA_PRECIOSViewManager  = new VT_MA_PRECIOSViewManager (ConnectionString,DatabaseEngine);
			_vT_MA_PRECIOS_ARTICULOSViewManager  = new VT_MA_PRECIOS_ARTICULOSViewManager (ConnectionString,DatabaseEngine);
			_vT_MAX_NRO_CPTE_ASIENTOSViewManager  = new VT_MAX_NRO_CPTE_ASIENTOSViewManager (ConnectionString,DatabaseEngine);
			_vT_MV_APLICACIONViewManager  = new VT_MV_APLICACIONViewManager (ConnectionString,DatabaseEngine);
			_vT_MV_CUOTAS_IMPAGASViewManager  = new VT_MV_CUOTAS_IMPAGASViewManager (ConnectionString,DatabaseEngine);
			_vT_MV_CUOTAS_PAGASViewManager  = new VT_MV_CUOTAS_PAGASViewManager (ConnectionString,DatabaseEngine);
			_vT_MV_Diarios_DescripViewManager  = new VT_MV_Diarios_DescripViewManager (ConnectionString,DatabaseEngine);
			_vT_PLANILLASMovilesViewManager  = new VT_PLANILLASMovilesViewManager (ConnectionString,DatabaseEngine);
			_vt_ProveedoresViewManager  = new Vt_ProveedoresViewManager (ConnectionString,DatabaseEngine);
			_vT_RankingConsumoViewManager  = new VT_RankingConsumoViewManager (ConnectionString,DatabaseEngine);
			_vT_RankingConsumo_ClienteViewManager  = new VT_RankingConsumo_ClienteViewManager (ConnectionString,DatabaseEngine);
			_vT_RubroTipoArticulosDescripcionesViewManager  = new VT_RubroTipoArticulosDescripcionesViewManager (ConnectionString,DatabaseEngine);
			_vT_RubroTipoDescripcionesViewManager  = new VT_RubroTipoDescripcionesViewManager (ConnectionString,DatabaseEngine);
			_vT_TA_PLANTILLAS_FORMULARIOSViewManager  = new VT_TA_PLANTILLAS_FORMULARIOSViewManager (ConnectionString,DatabaseEngine);
			_vT_ULTIMOS_PRECIOS_COMPRAViewManager  = new VT_ULTIMOS_PRECIOS_COMPRAViewManager (ConnectionString,DatabaseEngine);
			_vT_ULTIMOS_PRECIOS_VENTAViewManager  = new VT_ULTIMOS_PRECIOS_VENTAViewManager (ConnectionString,DatabaseEngine);
			_vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager  = new VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager (ConnectionString,DatabaseEngine);
			_vT_V_MV_INSUMOS_APLICACIONViewManager  = new VT_V_MV_INSUMOS_APLICACIONViewManager (ConnectionString,DatabaseEngine);
			_vT_V_TA_CPTEViewManager  = new VT_V_TA_CPTEViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileArticulosViewManager  = new wsSysMobileArticulosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileClientesViewManager  = new wsSysMobileClientesViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileDepositosViewManager  = new wsSysMobileDepositosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileRubrosViewManager  = new wsSysMobileRubrosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileStockArticulosViewManager  = new wsSysMobileStockArticulosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileStockArticulosDepositosViewManager  = new wsSysMobileStockArticulosDepositosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileStockComprometidoArticulosViewManager  = new wsSysMobileStockComprometidoArticulosViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileTotalRegistrosTablasViewManager  = new wsSysMobileTotalRegistrosTablasViewManager (ConnectionString,DatabaseEngine);
			_wsSysMobileVendedoresViewManager  = new wsSysMobileVendedoresViewManager (ConnectionString,DatabaseEngine);
		}

	}
}
