using System;
using SysWork.Data.GenericDataManager;
using SysWork.Data.GenericDataManager.Intefaces;
using SysWork.SWCG.Test.Entities.Repositories;
using SysWork.SWCG.Test.Entities.ViewManagers;
namespace SysWork.SWCG.Test.Entities
{
	/// <summary>
	/// This class was created automatically with the DataManagerClassWriter.
	/// </summary>

	public partial class DataManager : BaseDataManager<DataManager>, IDataManager
	{
		//Repositories
		private Lazy<AUX_ANEXOARepository> _aUX_ANEXOARepository;
		public AUX_ANEXOARepository AUX_ANEXOARepository {get => _aUX_ANEXOARepository.Value;}

		private Lazy<AUX_BALANCEGRALRepository> _aUX_BALANCEGRALRepository;
		public AUX_BALANCEGRALRepository AUX_BALANCEGRALRepository {get => _aUX_BALANCEGRALRepository.Value;}

		private Lazy<AUX_EST_PRODRepository> _aUX_EST_PRODRepository;
		public AUX_EST_PRODRepository AUX_EST_PRODRepository {get => _aUX_EST_PRODRepository.Value;}

		private Lazy<AUX_EstadisticaCtaRepository> _aUX_EstadisticaCtaRepository;
		public AUX_EstadisticaCtaRepository AUX_EstadisticaCtaRepository {get => _aUX_EstadisticaCtaRepository.Value;}

		private Lazy<AUX_MAYORESRepository> _aUX_MAYORESRepository;
		public AUX_MAYORESRepository AUX_MAYORESRepository {get => _aUX_MAYORESRepository.Value;}

		private Lazy<Aux_MV_CpteQRRepository> _aux_MV_CpteQRRepository;
		public Aux_MV_CpteQRRepository Aux_MV_CpteQRRepository {get => _aux_MV_CpteQRRepository.Value;}

		private Lazy<Aux_MV_CpteRepository> _aux_MV_CpteRepository;
		public Aux_MV_CpteRepository Aux_MV_CpteRepository {get => _aux_MV_CpteRepository.Value;}

		private Lazy<AUX_SALDOSMENSUALESRepository> _aUX_SALDOSMENSUALESRepository;
		public AUX_SALDOSMENSUALESRepository AUX_SALDOSMENSUALESRepository {get => _aUX_SALDOSMENSUALESRepository.Value;}

		private Lazy<AUX_SUBDIARIOSRepository> _aUX_SUBDIARIOSRepository;
		public AUX_SUBDIARIOSRepository AUX_SUBDIARIOSRepository {get => _aUX_SUBDIARIOSRepository.Value;}

		private Lazy<AUX_TMPRepository> _aUX_TMPRepository;
		public AUX_TMPRepository AUX_TMPRepository {get => _aUX_TMPRepository.Value;}

		private Lazy<AUX_TOTALES_DETRepository> _aUX_TOTALES_DETRepository;
		public AUX_TOTALES_DETRepository AUX_TOTALES_DETRepository {get => _aUX_TOTALES_DETRepository.Value;}

		private Lazy<Aux_totalesRepository> _aux_totalesRepository;
		public Aux_totalesRepository Aux_totalesRepository {get => _aux_totalesRepository.Value;}

		private Lazy<C_MV_CPTE_OBSERVRepository> _c_MV_CPTE_OBSERVRepository;
		public C_MV_CPTE_OBSERVRepository C_MV_CPTE_OBSERVRepository {get => _c_MV_CPTE_OBSERVRepository.Value;}

		private Lazy<C_MV_CPTE_PERCEPCIONESRepository> _c_MV_CPTE_PERCEPCIONESRepository;
		public C_MV_CPTE_PERCEPCIONESRepository C_MV_CPTE_PERCEPCIONESRepository {get => _c_MV_CPTE_PERCEPCIONESRepository.Value;}

		private Lazy<C_MV_CpteInsumosRepository> _c_MV_CpteInsumosRepository;
		public C_MV_CpteInsumosRepository C_MV_CpteInsumosRepository {get => _c_MV_CpteInsumosRepository.Value;}

		private Lazy<C_MV_CpteRepository> _c_MV_CpteRepository;
		public C_MV_CpteRepository C_MV_CpteRepository {get => _c_MV_CpteRepository.Value;}

		private Lazy<C_MV_CpteTareasRepository> _c_MV_CpteTareasRepository;
		public C_MV_CpteTareasRepository C_MV_CpteTareasRepository {get => _c_MV_CpteTareasRepository.Value;}

		private Lazy<C_Proveedores_CCompraRepository> _c_Proveedores_CCompraRepository;
		public C_Proveedores_CCompraRepository C_Proveedores_CCompraRepository {get => _c_Proveedores_CCompraRepository.Value;}

		private Lazy<CONTROL_ACCESORepository> _cONTROL_ACCESORepository;
		public CONTROL_ACCESORepository CONTROL_ACCESORepository {get => _cONTROL_ACCESORepository.Value;}

		private Lazy<Control_MV_CalculoRepository> _control_MV_CalculoRepository;
		public Control_MV_CalculoRepository Control_MV_CalculoRepository {get => _control_MV_CalculoRepository.Value;}

		private Lazy<CRM_MV_EVENTOSRepository> _cRM_MV_EVENTOSRepository;
		public CRM_MV_EVENTOSRepository CRM_MV_EVENTOSRepository {get => _cRM_MV_EVENTOSRepository.Value;}

		private Lazy<CRM_TA_EVENTOSRepository> _cRM_TA_EVENTOSRepository;
		public CRM_TA_EVENTOSRepository CRM_TA_EVENTOSRepository {get => _cRM_TA_EVENTOSRepository.Value;}

		private Lazy<dtpropertiesRepository> _dtpropertiesRepository;
		public dtpropertiesRepository dtpropertiesRepository {get => _dtpropertiesRepository.Value;}

		private Lazy<EM_MV_PESADAS_TRIGORepository> _eM_MV_PESADAS_TRIGORepository;
		public EM_MV_PESADAS_TRIGORepository EM_MV_PESADAS_TRIGORepository {get => _eM_MV_PESADAS_TRIGORepository.Value;}

		private Lazy<EQ_COND_INTERFACESRepository> _eQ_COND_INTERFACESRepository;
		public EQ_COND_INTERFACESRepository EQ_COND_INTERFACESRepository {get => _eQ_COND_INTERFACESRepository.Value;}

		private Lazy<EQ_CONDIVA_IMPORTACIONRepository> _eQ_CONDIVA_IMPORTACIONRepository;
		public EQ_CONDIVA_IMPORTACIONRepository EQ_CONDIVA_IMPORTACIONRepository {get => _eQ_CONDIVA_IMPORTACIONRepository.Value;}

		private Lazy<EQ_CTA_INTERFACERepository> _eQ_CTA_INTERFACERepository;
		public EQ_CTA_INTERFACERepository EQ_CTA_INTERFACERepository {get => _eQ_CTA_INTERFACERepository.Value;}

		private Lazy<EQ_TC_INTERFACERepository> _eQ_TC_INTERFACERepository;
		public EQ_TC_INTERFACERepository EQ_TC_INTERFACERepository {get => _eQ_TC_INTERFACERepository.Value;}

		private Lazy<GM_V_MV_PLANILLA_CABRepository> _gM_V_MV_PLANILLA_CABRepository;
		public GM_V_MV_PLANILLA_CABRepository GM_V_MV_PLANILLA_CABRepository {get => _gM_V_MV_PLANILLA_CABRepository.Value;}

		private Lazy<GM_V_MV_PLANILLA_DETALLERepository> _gM_V_MV_PLANILLA_DETALLERepository;
		public GM_V_MV_PLANILLA_DETALLERepository GM_V_MV_PLANILLA_DETALLERepository {get => _gM_V_MV_PLANILLA_DETALLERepository.Value;}

		private Lazy<L_MA_LicenciasCategoriasRepository> _l_MA_LicenciasCategoriasRepository;
		public L_MA_LicenciasCategoriasRepository L_MA_LicenciasCategoriasRepository {get => _l_MA_LicenciasCategoriasRepository.Value;}

		private Lazy<L_MA_LICENCIASCtrolMedicoRepository> _l_MA_LICENCIASCtrolMedicoRepository;
		public L_MA_LICENCIASCtrolMedicoRepository L_MA_LICENCIASCtrolMedicoRepository {get => _l_MA_LICENCIASCtrolMedicoRepository.Value;}

		private Lazy<L_MA_LICENCIASDOCUMENTACIONRepository> _l_MA_LICENCIASDOCUMENTACIONRepository;
		public L_MA_LICENCIASDOCUMENTACIONRepository L_MA_LICENCIASDOCUMENTACIONRepository {get => _l_MA_LICENCIASDOCUMENTACIONRepository.Value;}

		private Lazy<L_MA_LICENCIASEXAMENESRepository> _l_MA_LICENCIASEXAMENESRepository;
		public L_MA_LICENCIASEXAMENESRepository L_MA_LICENCIASEXAMENESRepository {get => _l_MA_LICENCIASEXAMENESRepository.Value;}

		private Lazy<L_MA_LicenciasRepository> _l_MA_LicenciasRepository;
		public L_MA_LicenciasRepository L_MA_LicenciasRepository {get => _l_MA_LicenciasRepository.Value;}

		private Lazy<L_MV_LicenciasRepository> _l_MV_LicenciasRepository;
		public L_MV_LicenciasRepository L_MV_LicenciasRepository {get => _l_MV_LicenciasRepository.Value;}

		private Lazy<L_MV_RuitRepository> _l_MV_RuitRepository;
		public L_MV_RuitRepository L_MV_RuitRepository {get => _l_MV_RuitRepository.Value;}

		private Lazy<L_TA_CategoriasRepository> _l_TA_CategoriasRepository;
		public L_TA_CategoriasRepository L_TA_CategoriasRepository {get => _l_TA_CategoriasRepository.Value;}

		private Lazy<L_TA_ClaseLicenciaRepository> _l_TA_ClaseLicenciaRepository;
		public L_TA_ClaseLicenciaRepository L_TA_ClaseLicenciaRepository {get => _l_TA_ClaseLicenciaRepository.Value;}

		private Lazy<L_TA_ControlMedicoRepository> _l_TA_ControlMedicoRepository;
		public L_TA_ControlMedicoRepository L_TA_ControlMedicoRepository {get => _l_TA_ControlMedicoRepository.Value;}

		private Lazy<L_TA_DocumentacionRepository> _l_TA_DocumentacionRepository;
		public L_TA_DocumentacionRepository L_TA_DocumentacionRepository {get => _l_TA_DocumentacionRepository.Value;}

		private Lazy<L_TA_ExamenesRepository> _l_TA_ExamenesRepository;
		public L_TA_ExamenesRepository L_TA_ExamenesRepository {get => _l_TA_ExamenesRepository.Value;}

		private Lazy<L_TA_LocalidadesRepository> _l_TA_LocalidadesRepository;
		public L_TA_LocalidadesRepository L_TA_LocalidadesRepository {get => _l_TA_LocalidadesRepository.Value;}

		private Lazy<L_TA_PartidosRepository> _l_TA_PartidosRepository;
		public L_TA_PartidosRepository L_TA_PartidosRepository {get => _l_TA_PartidosRepository.Value;}

		private Lazy<L_TA_TipoDocRepository> _l_TA_TipoDocRepository;
		public L_TA_TipoDocRepository L_TA_TipoDocRepository {get => _l_TA_TipoDocRepository.Value;}

		private Lazy<LogDbRepository> _logDbRepository;
		public LogDbRepository LogDbRepository {get => _logDbRepository.Value;}

		private Lazy<MA_ARBOL_OPERATIVORepository> _mA_ARBOL_OPERATIVORepository;
		public MA_ARBOL_OPERATIVORepository MA_ARBOL_OPERATIVORepository {get => _mA_ARBOL_OPERATIVORepository.Value;}

		private Lazy<MA_BIENES_NOVEDADESRepository> _mA_BIENES_NOVEDADESRepository;
		public MA_BIENES_NOVEDADESRepository MA_BIENES_NOVEDADESRepository {get => _mA_BIENES_NOVEDADESRepository.Value;}

		private Lazy<MA_BIENESRepository> _mA_BIENESRepository;
		public MA_BIENESRepository MA_BIENESRepository {get => _mA_BIENESRepository.Value;}

		private Lazy<MA_CalendarioRepository> _mA_CalendarioRepository;
		public MA_CalendarioRepository MA_CalendarioRepository {get => _mA_CalendarioRepository.Value;}

		private Lazy<MA_CASH_CONTROLRepository> _mA_CASH_CONTROLRepository;
		public MA_CASH_CONTROLRepository MA_CASH_CONTROLRepository {get => _mA_CASH_CONTROLRepository.Value;}

		private Lazy<MA_CASH_CTAS_PRINCIPALESRepository> _mA_CASH_CTAS_PRINCIPALESRepository;
		public MA_CASH_CTAS_PRINCIPALESRepository MA_CASH_CTAS_PRINCIPALESRepository {get => _mA_CASH_CTAS_PRINCIPALESRepository.Value;}

		private Lazy<MA_CASH_DETALLERepository> _mA_CASH_DETALLERepository;
		public MA_CASH_DETALLERepository MA_CASH_DETALLERepository {get => _mA_CASH_DETALLERepository.Value;}

		private Lazy<MA_CASH_FLOWRepository> _mA_CASH_FLOWRepository;
		public MA_CASH_FLOWRepository MA_CASH_FLOWRepository {get => _mA_CASH_FLOWRepository.Value;}

		private Lazy<MA_CASH_GRUPORepository> _mA_CASH_GRUPORepository;
		public MA_CASH_GRUPORepository MA_CASH_GRUPORepository {get => _mA_CASH_GRUPORepository.Value;}

		private Lazy<MA_CASH_PROYECTADORepository> _mA_CASH_PROYECTADORepository;
		public MA_CASH_PROYECTADORepository MA_CASH_PROYECTADORepository {get => _mA_CASH_PROYECTADORepository.Value;}

		private Lazy<MA_CASHPFE_DETALLERepository> _mA_CASHPFE_DETALLERepository;
		public MA_CASHPFE_DETALLERepository MA_CASHPFE_DETALLERepository {get => _mA_CASHPFE_DETALLERepository.Value;}

		private Lazy<MA_CASHPFE_GRUPORepository> _mA_CASHPFE_GRUPORepository;
		public MA_CASHPFE_GRUPORepository MA_CASHPFE_GRUPORepository {get => _mA_CASHPFE_GRUPORepository.Value;}

		private Lazy<MA_CASHPFE_PROYECTADORepository> _mA_CASHPFE_PROYECTADORepository;
		public MA_CASHPFE_PROYECTADORepository MA_CASHPFE_PROYECTADORepository {get => _mA_CASHPFE_PROYECTADORepository.Value;}

		private Lazy<MA_CASHPFERepository> _mA_CASHPFERepository;
		public MA_CASHPFERepository MA_CASHPFERepository {get => _mA_CASHPFERepository.Value;}

		private Lazy<MA_ChoferesRepository> _mA_ChoferesRepository;
		public MA_ChoferesRepository MA_ChoferesRepository {get => _mA_ChoferesRepository.Value;}

		private Lazy<MA_CONTACTOS_ADICRepository> _mA_CONTACTOS_ADICRepository;
		public MA_CONTACTOS_ADICRepository MA_CONTACTOS_ADICRepository {get => _mA_CONTACTOS_ADICRepository.Value;}

		private Lazy<MA_CONTACTOSRepository> _mA_CONTACTOSRepository;
		public MA_CONTACTOSRepository MA_CONTACTOSRepository {get => _mA_CONTACTOSRepository.Value;}

		private Lazy<MA_CUENTAS_ALERTASRepository> _mA_CUENTAS_ALERTASRepository;
		public MA_CUENTAS_ALERTASRepository MA_CUENTAS_ALERTASRepository {get => _mA_CUENTAS_ALERTASRepository.Value;}

		private Lazy<MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository> _mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository;
		public MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository {get => _mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository.Value;}

		private Lazy<MA_CUENTAS_CTAS_BANCARIASRepository> _mA_CUENTAS_CTAS_BANCARIASRepository;
		public MA_CUENTAS_CTAS_BANCARIASRepository MA_CUENTAS_CTAS_BANCARIASRepository {get => _mA_CUENTAS_CTAS_BANCARIASRepository.Value;}

		private Lazy<MA_CUENTAS_DATOS_LABORALESRepository> _mA_CUENTAS_DATOS_LABORALESRepository;
		public MA_CUENTAS_DATOS_LABORALESRepository MA_CUENTAS_DATOS_LABORALESRepository {get => _mA_CUENTAS_DATOS_LABORALESRepository.Value;}

		private Lazy<MA_CUENTAS_DESCUENTO_RUBROSRepository> _mA_CUENTAS_DESCUENTO_RUBROSRepository;
		public MA_CUENTAS_DESCUENTO_RUBROSRepository MA_CUENTAS_DESCUENTO_RUBROSRepository {get => _mA_CUENTAS_DESCUENTO_RUBROSRepository.Value;}

		private Lazy<MA_CUENTAS_DIRECCIONESRepository> _mA_CUENTAS_DIRECCIONESRepository;
		public MA_CUENTAS_DIRECCIONESRepository MA_CUENTAS_DIRECCIONESRepository {get => _mA_CUENTAS_DIRECCIONESRepository.Value;}

		private Lazy<MA_CUENTAS_ENCOMIENDAS_CANTRepository> _mA_CUENTAS_ENCOMIENDAS_CANTRepository;
		public MA_CUENTAS_ENCOMIENDAS_CANTRepository MA_CUENTAS_ENCOMIENDAS_CANTRepository {get => _mA_CUENTAS_ENCOMIENDAS_CANTRepository.Value;}

		private Lazy<MA_CUENTAS_ENCOMIENDASRepository> _mA_CUENTAS_ENCOMIENDASRepository;
		public MA_CUENTAS_ENCOMIENDASRepository MA_CUENTAS_ENCOMIENDASRepository {get => _mA_CUENTAS_ENCOMIENDASRepository.Value;}

		private Lazy<MA_CUENTAS_FACTURACION_RECURRENTERepository> _mA_CUENTAS_FACTURACION_RECURRENTERepository;
		public MA_CUENTAS_FACTURACION_RECURRENTERepository MA_CUENTAS_FACTURACION_RECURRENTERepository {get => _mA_CUENTAS_FACTURACION_RECURRENTERepository.Value;}

		private Lazy<MA_CUENTAS_FAMILIASRepository> _mA_CUENTAS_FAMILIASRepository;
		public MA_CUENTAS_FAMILIASRepository MA_CUENTAS_FAMILIASRepository {get => _mA_CUENTAS_FAMILIASRepository.Value;}

		private Lazy<MA_CUENTAS_INFO_ADICIONALRepository> _mA_CUENTAS_INFO_ADICIONALRepository;
		public MA_CUENTAS_INFO_ADICIONALRepository MA_CUENTAS_INFO_ADICIONALRepository {get => _mA_CUENTAS_INFO_ADICIONALRepository.Value;}

		private Lazy<MA_CUENTAS_INFORMESRepository> _mA_CUENTAS_INFORMESRepository;
		public MA_CUENTAS_INFORMESRepository MA_CUENTAS_INFORMESRepository {get => _mA_CUENTAS_INFORMESRepository.Value;}

		private Lazy<MA_CUENTAS_RUTEO_VENDEDORRepository> _mA_CUENTAS_RUTEO_VENDEDORRepository;
		public MA_CUENTAS_RUTEO_VENDEDORRepository MA_CUENTAS_RUTEO_VENDEDORRepository {get => _mA_CUENTAS_RUTEO_VENDEDORRepository.Value;}

		private Lazy<MA_CUENTAS_SUCURSALESRepository> _mA_CUENTAS_SUCURSALESRepository;
		public MA_CUENTAS_SUCURSALESRepository MA_CUENTAS_SUCURSALESRepository {get => _mA_CUENTAS_SUCURSALESRepository.Value;}

		private Lazy<MA_CUENTAS_USUARIOSRepository> _mA_CUENTAS_USUARIOSRepository;
		public MA_CUENTAS_USUARIOSRepository MA_CUENTAS_USUARIOSRepository {get => _mA_CUENTAS_USUARIOSRepository.Value;}

		private Lazy<MA_CUENTASADICRepository> _mA_CUENTASADICRepository;
		public MA_CUENTASADICRepository MA_CUENTASADICRepository {get => _mA_CUENTASADICRepository.Value;}

		private Lazy<MA_CUENTASCCOSTORepository> _mA_CUENTASCCOSTORepository;
		public MA_CUENTASCCOSTORepository MA_CUENTASCCOSTORepository {get => _mA_CUENTASCCOSTORepository.Value;}

		private Lazy<MA_CUENTASRepository> _mA_CUENTASRepository;
		public MA_CUENTASRepository MA_CUENTASRepository {get => _mA_CUENTASRepository.Value;}

		private Lazy<MA_ESTADISTICACTARepository> _mA_ESTADISTICACTARepository;
		public MA_ESTADISTICACTARepository MA_ESTADISTICACTARepository {get => _mA_ESTADISTICACTARepository.Value;}

		private Lazy<MA_INDAJUSTERepository> _mA_INDAJUSTERepository;
		public MA_INDAJUSTERepository MA_INDAJUSTERepository {get => _mA_INDAJUSTERepository.Value;}

		private Lazy<MA_MODELOSRepository> _mA_MODELOSRepository;
		public MA_MODELOSRepository MA_MODELOSRepository {get => _mA_MODELOSRepository.Value;}

		private Lazy<MA_SUBDIARIOSCOMPROBANTESRepository> _mA_SUBDIARIOSCOMPROBANTESRepository;
		public MA_SUBDIARIOSCOMPROBANTESRepository MA_SUBDIARIOSCOMPROBANTESRepository {get => _mA_SUBDIARIOSCOMPROBANTESRepository.Value;}

		private Lazy<MA_SUBDIARIOSRepository> _mA_SUBDIARIOSRepository;
		public MA_SUBDIARIOSRepository MA_SUBDIARIOSRepository {get => _mA_SUBDIARIOSRepository.Value;}

		private Lazy<MA_vehiculosRepository> _mA_vehiculosRepository;
		public MA_vehiculosRepository MA_vehiculosRepository {get => _mA_vehiculosRepository.Value;}

		private Lazy<MV_AgendaRepository> _mV_AgendaRepository;
		public MV_AgendaRepository MV_AgendaRepository {get => _mV_AgendaRepository.Value;}

		private Lazy<MV_APLICACIONRepository> _mV_APLICACIONRepository;
		public MV_APLICACIONRepository MV_APLICACIONRepository {get => _mV_APLICACIONRepository.Value;}

		private Lazy<MV_ASIENTOSCCOSTORepository> _mV_ASIENTOSCCOSTORepository;
		public MV_ASIENTOSCCOSTORepository MV_ASIENTOSCCOSTORepository {get => _mV_ASIENTOSCCOSTORepository.Value;}

		private Lazy<MV_ASIENTOSRepository> _mV_ASIENTOSRepository;
		public MV_ASIENTOSRepository MV_ASIENTOSRepository {get => _mV_ASIENTOSRepository.Value;}

		private Lazy<MV_BIENES_DETALLERepository> _mV_BIENES_DETALLERepository;
		public MV_BIENES_DETALLERepository MV_BIENES_DETALLERepository {get => _mV_BIENES_DETALLERepository.Value;}

		private Lazy<MV_BIENESRepository> _mV_BIENESRepository;
		public MV_BIENESRepository MV_BIENESRepository {get => _mV_BIENESRepository.Value;}

		private Lazy<MV_CALCULO_BIENESRepository> _mV_CALCULO_BIENESRepository;
		public MV_CALCULO_BIENESRepository MV_CALCULO_BIENESRepository {get => _mV_CALCULO_BIENESRepository.Value;}

		private Lazy<MV_CONTROL_AS_RESRepository> _mV_CONTROL_AS_RESRepository;
		public MV_CONTROL_AS_RESRepository MV_CONTROL_AS_RESRepository {get => _mV_CONTROL_AS_RESRepository.Value;}

		private Lazy<MV_EJERCICIOSRepository> _mV_EJERCICIOSRepository;
		public MV_EJERCICIOSRepository MV_EJERCICIOSRepository {get => _mV_EJERCICIOSRepository.Value;}

		private Lazy<MV_INVENTARIOSCABRepository> _mV_INVENTARIOSCABRepository;
		public MV_INVENTARIOSCABRepository MV_INVENTARIOSCABRepository {get => _mV_INVENTARIOSCABRepository.Value;}

		private Lazy<MV_INVENTARIOSRepository> _mV_INVENTARIOSRepository;
		public MV_INVENTARIOSRepository MV_INVENTARIOSRepository {get => _mV_INVENTARIOSRepository.Value;}

		private Lazy<MV_SALDOSRepository> _mV_SALDOSRepository;
		public MV_SALDOSRepository MV_SALDOSRepository {get => _mV_SALDOSRepository.Value;}

		private Lazy<P_MA_ClientesRepository> _p_MA_ClientesRepository;
		public P_MA_ClientesRepository P_MA_ClientesRepository {get => _p_MA_ClientesRepository.Value;}

		private Lazy<P_MA_EmpresasRepository> _p_MA_EmpresasRepository;
		public P_MA_EmpresasRepository P_MA_EmpresasRepository {get => _p_MA_EmpresasRepository.Value;}

		private Lazy<P_MA_FamiliarRepository> _p_MA_FamiliarRepository;
		public P_MA_FamiliarRepository P_MA_FamiliarRepository {get => _p_MA_FamiliarRepository.Value;}

		private Lazy<P_MA_LegajosRepository> _p_MA_LegajosRepository;
		public P_MA_LegajosRepository P_MA_LegajosRepository {get => _p_MA_LegajosRepository.Value;}

		private Lazy<P_MA_PostulanteAuxiliarRepository> _p_MA_PostulanteAuxiliarRepository;
		public P_MA_PostulanteAuxiliarRepository P_MA_PostulanteAuxiliarRepository {get => _p_MA_PostulanteAuxiliarRepository.Value;}

		private Lazy<P_MA_Postulantes_ConocimientosRepository> _p_MA_Postulantes_ConocimientosRepository;
		public P_MA_Postulantes_ConocimientosRepository P_MA_Postulantes_ConocimientosRepository {get => _p_MA_Postulantes_ConocimientosRepository.Value;}

		private Lazy<P_MA_Postulantes_ExperienciaRepository> _p_MA_Postulantes_ExperienciaRepository;
		public P_MA_Postulantes_ExperienciaRepository P_MA_Postulantes_ExperienciaRepository {get => _p_MA_Postulantes_ExperienciaRepository.Value;}

		private Lazy<P_MA_Postulantes_IdiomasRepository> _p_MA_Postulantes_IdiomasRepository;
		public P_MA_Postulantes_IdiomasRepository P_MA_Postulantes_IdiomasRepository {get => _p_MA_Postulantes_IdiomasRepository.Value;}

		private Lazy<P_MA_Postulantes_ObsRepository> _p_MA_Postulantes_ObsRepository;
		public P_MA_Postulantes_ObsRepository P_MA_Postulantes_ObsRepository {get => _p_MA_Postulantes_ObsRepository.Value;}

		private Lazy<P_MA_Postulantes_TitulosRepository> _p_MA_Postulantes_TitulosRepository;
		public P_MA_Postulantes_TitulosRepository P_MA_Postulantes_TitulosRepository {get => _p_MA_Postulantes_TitulosRepository.Value;}

		private Lazy<P_MA_PostulantesRepository> _p_MA_PostulantesRepository;
		public P_MA_PostulantesRepository P_MA_PostulantesRepository {get => _p_MA_PostulantesRepository.Value;}

		private Lazy<P_MV_BusquedasRepository> _p_MV_BusquedasRepository;
		public P_MV_BusquedasRepository P_MV_BusquedasRepository {get => _p_MV_BusquedasRepository.Value;}

		private Lazy<P_MV_CtrolHorariosRepository> _p_MV_CtrolHorariosRepository;
		public P_MV_CtrolHorariosRepository P_MV_CtrolHorariosRepository {get => _p_MV_CtrolHorariosRepository.Value;}

		private Lazy<P_MV_DeudoresRepository> _p_MV_DeudoresRepository;
		public P_MV_DeudoresRepository P_MV_DeudoresRepository {get => _p_MV_DeudoresRepository.Value;}

		private Lazy<P_MV_EntrevistasRepository> _p_MV_EntrevistasRepository;
		public P_MV_EntrevistasRepository P_MV_EntrevistasRepository {get => _p_MV_EntrevistasRepository.Value;}

		private Lazy<P_MV_ReferenciasRepository> _p_MV_ReferenciasRepository;
		public P_MV_ReferenciasRepository P_MV_ReferenciasRepository {get => _p_MV_ReferenciasRepository.Value;}

		private Lazy<P_MV_SeguimientoRepository> _p_MV_SeguimientoRepository;
		public P_MV_SeguimientoRepository P_MV_SeguimientoRepository {get => _p_MV_SeguimientoRepository.Value;}

		private Lazy<P_MV_SolicitudRRHH_ConocimientosRepository> _p_MV_SolicitudRRHH_ConocimientosRepository;
		public P_MV_SolicitudRRHH_ConocimientosRepository P_MV_SolicitudRRHH_ConocimientosRepository {get => _p_MV_SolicitudRRHH_ConocimientosRepository.Value;}

		private Lazy<P_MV_SolicitudRRHH_IdiomasRepository> _p_MV_SolicitudRRHH_IdiomasRepository;
		public P_MV_SolicitudRRHH_IdiomasRepository P_MV_SolicitudRRHH_IdiomasRepository {get => _p_MV_SolicitudRRHH_IdiomasRepository.Value;}

		private Lazy<P_MV_SolicitudRRHH_TitulosRepository> _p_MV_SolicitudRRHH_TitulosRepository;
		public P_MV_SolicitudRRHH_TitulosRepository P_MV_SolicitudRRHH_TitulosRepository {get => _p_MV_SolicitudRRHH_TitulosRepository.Value;}

		private Lazy<P_MV_SolicitudRRHHRepository> _p_MV_SolicitudRRHHRepository;
		public P_MV_SolicitudRRHHRepository P_MV_SolicitudRRHHRepository {get => _p_MV_SolicitudRRHHRepository.Value;}

		private Lazy<P_TA_AreasRepository> _p_TA_AreasRepository;
		public P_TA_AreasRepository P_TA_AreasRepository {get => _p_TA_AreasRepository.Value;}

		private Lazy<P_TA_CategorizacionRepository> _p_TA_CategorizacionRepository;
		public P_TA_CategorizacionRepository P_TA_CategorizacionRepository {get => _p_TA_CategorizacionRepository.Value;}

		private Lazy<P_TA_CentroMedicoRepository> _p_TA_CentroMedicoRepository;
		public P_TA_CentroMedicoRepository P_TA_CentroMedicoRepository {get => _p_TA_CentroMedicoRepository.Value;}

		private Lazy<P_Ta_ConocimientosRepository> _p_Ta_ConocimientosRepository;
		public P_Ta_ConocimientosRepository P_Ta_ConocimientosRepository {get => _p_Ta_ConocimientosRepository.Value;}

		private Lazy<P_TA_EstadoBusquedaRepository> _p_TA_EstadoBusquedaRepository;
		public P_TA_EstadoBusquedaRepository P_TA_EstadoBusquedaRepository {get => _p_TA_EstadoBusquedaRepository.Value;}

		private Lazy<P_TA_EstadoCivilRepository> _p_TA_EstadoCivilRepository;
		public P_TA_EstadoCivilRepository P_TA_EstadoCivilRepository {get => _p_TA_EstadoCivilRepository.Value;}

		private Lazy<P_TA_EstadoPostulanteRepository> _p_TA_EstadoPostulanteRepository;
		public P_TA_EstadoPostulanteRepository P_TA_EstadoPostulanteRepository {get => _p_TA_EstadoPostulanteRepository.Value;}

		private Lazy<P_TA_FormasDePagoRepository> _p_TA_FormasDePagoRepository;
		public P_TA_FormasDePagoRepository P_TA_FormasDePagoRepository {get => _p_TA_FormasDePagoRepository.Value;}

		private Lazy<P_TA_FuncionesRepository> _p_TA_FuncionesRepository;
		public P_TA_FuncionesRepository P_TA_FuncionesRepository {get => _p_TA_FuncionesRepository.Value;}

		private Lazy<P_TA_GruposRepository> _p_TA_GruposRepository;
		public P_TA_GruposRepository P_TA_GruposRepository {get => _p_TA_GruposRepository.Value;}

		private Lazy<P_TA_IdiomasRepository> _p_TA_IdiomasRepository;
		public P_TA_IdiomasRepository P_TA_IdiomasRepository {get => _p_TA_IdiomasRepository.Value;}

		private Lazy<P_TA_MotivoEgresoRepository> _p_TA_MotivoEgresoRepository;
		public P_TA_MotivoEgresoRepository P_TA_MotivoEgresoRepository {get => _p_TA_MotivoEgresoRepository.Value;}

		private Lazy<P_TA_NivelEstudioRepository> _p_TA_NivelEstudioRepository;
		public P_TA_NivelEstudioRepository P_TA_NivelEstudioRepository {get => _p_TA_NivelEstudioRepository.Value;}

		private Lazy<P_TA_ObraSocialRepository> _p_TA_ObraSocialRepository;
		public P_TA_ObraSocialRepository P_TA_ObraSocialRepository {get => _p_TA_ObraSocialRepository.Value;}

		private Lazy<P_TA_ParentescoRepository> _p_TA_ParentescoRepository;
		public P_TA_ParentescoRepository P_TA_ParentescoRepository {get => _p_TA_ParentescoRepository.Value;}

		private Lazy<P_TA_SindicatosRepository> _p_TA_SindicatosRepository;
		public P_TA_SindicatosRepository P_TA_SindicatosRepository {get => _p_TA_SindicatosRepository.Value;}

		private Lazy<P_TA_TipoPuestoRepository> _p_TA_TipoPuestoRepository;
		public P_TA_TipoPuestoRepository P_TA_TipoPuestoRepository {get => _p_TA_TipoPuestoRepository.Value;}

		private Lazy<P_TA_TitulosRepository> _p_TA_TitulosRepository;
		public P_TA_TitulosRepository P_TA_TitulosRepository {get => _p_TA_TitulosRepository.Value;}

		private Lazy<P_TA_ZonaResidenciaRepository> _p_TA_ZonaResidenciaRepository;
		public P_TA_ZonaResidenciaRepository P_TA_ZonaResidenciaRepository {get => _p_TA_ZonaResidenciaRepository.Value;}

		private Lazy<PRUEBAESTADISTICARepository> _pRUEBAESTADISTICARepository;
		public PRUEBAESTADISTICARepository PRUEBAESTADISTICARepository {get => _pRUEBAESTADISTICARepository.Value;}

		private Lazy<RMA_ESTADOSRepository> _rMA_ESTADOSRepository;
		public RMA_ESTADOSRepository RMA_ESTADOSRepository {get => _rMA_ESTADOSRepository.Value;}

		private Lazy<RMA_MOTIVOSRepository> _rMA_MOTIVOSRepository;
		public RMA_MOTIVOSRepository RMA_MOTIVOSRepository {get => _rMA_MOTIVOSRepository.Value;}

		private Lazy<RMA_TRAZABILIDAD_ARTICULOSRepository> _rMA_TRAZABILIDAD_ARTICULOSRepository;
		public RMA_TRAZABILIDAD_ARTICULOSRepository RMA_TRAZABILIDAD_ARTICULOSRepository {get => _rMA_TRAZABILIDAD_ARTICULOSRepository.Value;}

		private Lazy<S_TA_EQUIVRepository> _s_TA_EQUIVRepository;
		public S_TA_EQUIVRepository S_TA_EQUIVRepository {get => _s_TA_EQUIVRepository.Value;}

		private Lazy<T_VEHICULOS_NOVEDADESRepository> _t_VEHICULOS_NOVEDADESRepository;
		public T_VEHICULOS_NOVEDADESRepository T_VEHICULOS_NOVEDADESRepository {get => _t_VEHICULOS_NOVEDADESRepository.Value;}

		private Lazy<TA_AGRUPCUENTAS_DETALLERepository> _tA_AGRUPCUENTAS_DETALLERepository;
		public TA_AGRUPCUENTAS_DETALLERepository TA_AGRUPCUENTAS_DETALLERepository {get => _tA_AGRUPCUENTAS_DETALLERepository.Value;}

		private Lazy<TA_AGRUPCUENTASRepository> _tA_AGRUPCUENTASRepository;
		public TA_AGRUPCUENTASRepository TA_AGRUPCUENTASRepository {get => _tA_AGRUPCUENTASRepository.Value;}

		private Lazy<Ta_ArchivoLegalRepository> _ta_ArchivoLegalRepository;
		public Ta_ArchivoLegalRepository Ta_ArchivoLegalRepository {get => _ta_ArchivoLegalRepository.Value;}

		private Lazy<TA_AUDITORIARepository> _tA_AUDITORIARepository;
		public TA_AUDITORIARepository TA_AUDITORIARepository {get => _tA_AUDITORIARepository.Value;}

		private Lazy<TA_BIENES_CCOSTORepository> _tA_BIENES_CCOSTORepository;
		public TA_BIENES_CCOSTORepository TA_BIENES_CCOSTORepository {get => _tA_BIENES_CCOSTORepository.Value;}

		private Lazy<TA_BIENES_CLASESRepository> _tA_BIENES_CLASESRepository;
		public TA_BIENES_CLASESRepository TA_BIENES_CLASESRepository {get => _tA_BIENES_CLASESRepository.Value;}

		private Lazy<TA_BIENES_ESTADOSRepository> _tA_BIENES_ESTADOSRepository;
		public TA_BIENES_ESTADOSRepository TA_BIENES_ESTADOSRepository {get => _tA_BIENES_ESTADOSRepository.Value;}

		private Lazy<TA_BIENES_MARCASRepository> _tA_BIENES_MARCASRepository;
		public TA_BIENES_MARCASRepository TA_BIENES_MARCASRepository {get => _tA_BIENES_MARCASRepository.Value;}

		private Lazy<TA_BIENES_MOTIVOSRepository> _tA_BIENES_MOTIVOSRepository;
		public TA_BIENES_MOTIVOSRepository TA_BIENES_MOTIVOSRepository {get => _tA_BIENES_MOTIVOSRepository.Value;}

		private Lazy<TA_BIENES_PROPIETARIOSRepository> _tA_BIENES_PROPIETARIOSRepository;
		public TA_BIENES_PROPIETARIOSRepository TA_BIENES_PROPIETARIOSRepository {get => _tA_BIENES_PROPIETARIOSRepository.Value;}

		private Lazy<TA_BIENES_TIPOSRepository> _tA_BIENES_TIPOSRepository;
		public TA_BIENES_TIPOSRepository TA_BIENES_TIPOSRepository {get => _tA_BIENES_TIPOSRepository.Value;}

		private Lazy<TA_CCOSTORepository> _tA_CCOSTORepository;
		public TA_CCOSTORepository TA_CCOSTORepository {get => _tA_CCOSTORepository.Value;}

		private Lazy<TA_COMPROBANTESRepository> _tA_COMPROBANTESRepository;
		public TA_COMPROBANTESRepository TA_COMPROBANTESRepository {get => _tA_COMPROBANTESRepository.Value;}

		private Lazy<TA_CONDIVARepository> _tA_CONDIVARepository;
		public TA_CONDIVARepository TA_CONDIVARepository {get => _tA_CONDIVARepository.Value;}

		private Lazy<TA_CONFIGURACIONRepository> _tA_CONFIGURACIONRepository;
		public TA_CONFIGURACIONRepository TA_CONFIGURACIONRepository {get => _tA_CONFIGURACIONRepository.Value;}

		private Lazy<TA_COTIZACIONRepository> _tA_COTIZACIONRepository;
		public TA_COTIZACIONRepository TA_COTIZACIONRepository {get => _tA_COTIZACIONRepository.Value;}

		private Lazy<TA_CUENTAS_COMPROBANTESRepository> _tA_CUENTAS_COMPROBANTESRepository;
		public TA_CUENTAS_COMPROBANTESRepository TA_CUENTAS_COMPROBANTESRepository {get => _tA_CUENTAS_COMPROBANTESRepository.Value;}

		private Lazy<TA_CUENTASIVARepository> _tA_CUENTASIVARepository;
		public TA_CUENTASIVARepository TA_CUENTASIVARepository {get => _tA_CUENTASIVARepository.Value;}

		private Lazy<TA_DistLocalidadesRepository> _tA_DistLocalidadesRepository;
		public TA_DistLocalidadesRepository TA_DistLocalidadesRepository {get => _tA_DistLocalidadesRepository.Value;}

		private Lazy<TA_ESTADOSRepository> _tA_ESTADOSRepository;
		public TA_ESTADOSRepository TA_ESTADOSRepository {get => _tA_ESTADOSRepository.Value;}

		private Lazy<TA_IMPORTACUENTASDETALLERepository> _tA_IMPORTACUENTASDETALLERepository;
		public TA_IMPORTACUENTASDETALLERepository TA_IMPORTACUENTASDETALLERepository {get => _tA_IMPORTACUENTASDETALLERepository.Value;}

		private Lazy<TA_IMPORTACUENTASRepository> _tA_IMPORTACUENTASRepository;
		public TA_IMPORTACUENTASRepository TA_IMPORTACUENTASRepository {get => _tA_IMPORTACUENTASRepository.Value;}

		private Lazy<TA_INTERFACES_DETALLERepository> _tA_INTERFACES_DETALLERepository;
		public TA_INTERFACES_DETALLERepository TA_INTERFACES_DETALLERepository {get => _tA_INTERFACES_DETALLERepository.Value;}

		private Lazy<TA_INTERFACESRepository> _tA_INTERFACESRepository;
		public TA_INTERFACESRepository TA_INTERFACESRepository {get => _tA_INTERFACESRepository.Value;}

		private Lazy<TA_LOGOSRepository> _tA_LOGOSRepository;
		public TA_LOGOSRepository TA_LOGOSRepository {get => _tA_LOGOSRepository.Value;}

		private Lazy<TA_MARCASRepository> _tA_MARCASRepository;
		public TA_MARCASRepository TA_MARCASRepository {get => _tA_MARCASRepository.Value;}

		private Lazy<TA_MENURepository> _tA_MENURepository;
		public TA_MENURepository TA_MENURepository {get => _tA_MENURepository.Value;}

		private Lazy<TA_MONEDASRepository> _tA_MONEDASRepository;
		public TA_MONEDASRepository TA_MONEDASRepository {get => _tA_MONEDASRepository.Value;}

		private Lazy<Ta_NumArchivoLegalRepository> _ta_NumArchivoLegalRepository;
		public Ta_NumArchivoLegalRepository Ta_NumArchivoLegalRepository {get => _ta_NumArchivoLegalRepository.Value;}

		private Lazy<TA_PAISESRepository> _tA_PAISESRepository;
		public TA_PAISESRepository TA_PAISESRepository {get => _tA_PAISESRepository.Value;}

		private Lazy<TA_PUBLICACIONESRepository> _tA_PUBLICACIONESRepository;
		public TA_PUBLICACIONESRepository TA_PUBLICACIONESRepository {get => _tA_PUBLICACIONESRepository.Value;}

		private Lazy<TA_RANGOS_DATOS_ADICRepository> _tA_RANGOS_DATOS_ADICRepository;
		public TA_RANGOS_DATOS_ADICRepository TA_RANGOS_DATOS_ADICRepository {get => _tA_RANGOS_DATOS_ADICRepository.Value;}

		private Lazy<TA_REPORTESRepository> _tA_REPORTESRepository;
		public TA_REPORTESRepository TA_REPORTESRepository {get => _tA_REPORTESRepository.Value;}

		private Lazy<TA_TAREASRepository> _tA_TAREASRepository;
		public TA_TAREASRepository TA_TAREASRepository {get => _tA_TAREASRepository.Value;}

		private Lazy<TA_TERMINALESRepository> _tA_TERMINALESRepository;
		public TA_TERMINALESRepository TA_TERMINALESRepository {get => _tA_TERMINALESRepository.Value;}

		private Lazy<TA_TIPODOCUMENTORepository> _tA_TIPODOCUMENTORepository;
		public TA_TIPODOCUMENTORepository TA_TIPODOCUMENTORepository {get => _tA_TIPODOCUMENTORepository.Value;}

		private Lazy<TA_TIPOVEHICULORepository> _tA_TIPOVEHICULORepository;
		public TA_TIPOVEHICULORepository TA_TIPOVEHICULORepository {get => _tA_TIPOVEHICULORepository.Value;}

		private Lazy<TA_TITCOPIADORESRepository> _tA_TITCOPIADORESRepository;
		public TA_TITCOPIADORESRepository TA_TITCOPIADORESRepository {get => _tA_TITCOPIADORESRepository.Value;}

		private Lazy<TA_USUARIOSRepository> _tA_USUARIOSRepository;
		public TA_USUARIOSRepository TA_USUARIOSRepository {get => _tA_USUARIOSRepository.Value;}

		private Lazy<TA_VISTASRepository> _tA_VISTASRepository;
		public TA_VISTASRepository TA_VISTASRepository {get => _tA_VISTASRepository.Value;}

		private Lazy<TESTIGO_EXPORTACIONRepository> _tESTIGO_EXPORTACIONRepository;
		public TESTIGO_EXPORTACIONRepository TESTIGO_EXPORTACIONRepository {get => _tESTIGO_EXPORTACIONRepository.Value;}

		private Lazy<TESTIGO_RECEPCIONRepository> _tESTIGO_RECEPCIONRepository;
		public TESTIGO_RECEPCIONRepository TESTIGO_RECEPCIONRepository {get => _tESTIGO_RECEPCIONRepository.Value;}

		private Lazy<TMP_BusquedaPrecioRepository> _tMP_BusquedaPrecioRepository;
		public TMP_BusquedaPrecioRepository TMP_BusquedaPrecioRepository {get => _tMP_BusquedaPrecioRepository.Value;}

		private Lazy<UTL_TA_VENTANASRepository> _uTL_TA_VENTANASRepository;
		public UTL_TA_VENTANASRepository UTL_TA_VENTANASRepository {get => _uTL_TA_VENTANASRepository.Value;}

		private Lazy<V_CRM_MV_CPTERepository> _v_CRM_MV_CPTERepository;
		public V_CRM_MV_CPTERepository V_CRM_MV_CPTERepository {get => _v_CRM_MV_CPTERepository.Value;}

		private Lazy<V_CRM_TA_ACCIONESRepository> _v_CRM_TA_ACCIONESRepository;
		public V_CRM_TA_ACCIONESRepository V_CRM_TA_ACCIONESRepository {get => _v_CRM_TA_ACCIONESRepository.Value;}

		private Lazy<V_CRM_TA_ESTADOSRepository> _v_CRM_TA_ESTADOSRepository;
		public V_CRM_TA_ESTADOSRepository V_CRM_TA_ESTADOSRepository {get => _v_CRM_TA_ESTADOSRepository.Value;}

		private Lazy<V_FIDELIZACION_ARTICULOSRepository> _v_FIDELIZACION_ARTICULOSRepository;
		public V_FIDELIZACION_ARTICULOSRepository V_FIDELIZACION_ARTICULOSRepository {get => _v_FIDELIZACION_ARTICULOSRepository.Value;}

		private Lazy<V_FIDELIZACION_MV_PUNTOSRepository> _v_FIDELIZACION_MV_PUNTOSRepository;
		public V_FIDELIZACION_MV_PUNTOSRepository V_FIDELIZACION_MV_PUNTOSRepository {get => _v_FIDELIZACION_MV_PUNTOSRepository.Value;}

		private Lazy<V_FIDELIZACIONRepository> _v_FIDELIZACIONRepository;
		public V_FIDELIZACIONRepository V_FIDELIZACIONRepository {get => _v_FIDELIZACIONRepository.Value;}

		private Lazy<V_MA_AERONAVES_COMPONENTESRepository> _v_MA_AERONAVES_COMPONENTESRepository;
		public V_MA_AERONAVES_COMPONENTESRepository V_MA_AERONAVES_COMPONENTESRepository {get => _v_MA_AERONAVES_COMPONENTESRepository.Value;}

		private Lazy<V_MA_AERONAVES_DOCUMENTOSRepository> _v_MA_AERONAVES_DOCUMENTOSRepository;
		public V_MA_AERONAVES_DOCUMENTOSRepository V_MA_AERONAVES_DOCUMENTOSRepository {get => _v_MA_AERONAVES_DOCUMENTOSRepository.Value;}

		private Lazy<V_MA_AERONAVESRepository> _v_MA_AERONAVESRepository;
		public V_MA_AERONAVESRepository V_MA_AERONAVESRepository {get => _v_MA_AERONAVESRepository.Value;}

		private Lazy<V_MA_ARTICULOS_ALERTASRepository> _v_MA_ARTICULOS_ALERTASRepository;
		public V_MA_ARTICULOS_ALERTASRepository V_MA_ARTICULOS_ALERTASRepository {get => _v_MA_ARTICULOS_ALERTASRepository.Value;}

		private Lazy<V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository> _v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository;
		public V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository {get => _v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository.Value;}

		private Lazy<V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository> _v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository;
		public V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository {get => _v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository.Value;}

		private Lazy<V_MA_ARTICULOS_SINONIMOSRepository> _v_MA_ARTICULOS_SINONIMOSRepository;
		public V_MA_ARTICULOS_SINONIMOSRepository V_MA_ARTICULOS_SINONIMOSRepository {get => _v_MA_ARTICULOS_SINONIMOSRepository.Value;}

		private Lazy<V_MA_ARTICULOSRepository> _v_MA_ARTICULOSRepository;
		public V_MA_ARTICULOSRepository V_MA_ARTICULOSRepository {get => _v_MA_ARTICULOSRepository.Value;}

		private Lazy<V_MA_EXPRESOSRepository> _v_MA_EXPRESOSRepository;
		public V_MA_EXPRESOSRepository V_MA_EXPRESOSRepository {get => _v_MA_EXPRESOSRepository.Value;}

		private Lazy<V_MA_INSUMOSRepository> _v_MA_INSUMOSRepository;
		public V_MA_INSUMOSRepository V_MA_INSUMOSRepository {get => _v_MA_INSUMOSRepository.Value;}

		private Lazy<V_MA_POSICRepository> _v_MA_POSICRepository;
		public V_MA_POSICRepository V_MA_POSICRepository {get => _v_MA_POSICRepository.Value;}

		private Lazy<V_MA_PreciosRepository> _v_MA_PreciosRepository;
		public V_MA_PreciosRepository V_MA_PreciosRepository {get => _v_MA_PreciosRepository.Value;}

		private Lazy<V_MV_CPTE_OBSERVRepository> _v_MV_CPTE_OBSERVRepository;
		public V_MV_CPTE_OBSERVRepository V_MV_CPTE_OBSERVRepository {get => _v_MV_CPTE_OBSERVRepository.Value;}

		private Lazy<V_MV_CpteAccionesRepository> _v_MV_CpteAccionesRepository;
		public V_MV_CpteAccionesRepository V_MV_CpteAccionesRepository {get => _v_MV_CpteAccionesRepository.Value;}

		private Lazy<V_MV_CpteDocRepository> _v_MV_CpteDocRepository;
		public V_MV_CpteDocRepository V_MV_CpteDocRepository {get => _v_MV_CpteDocRepository.Value;}

		private Lazy<V_MV_CpteEnComisionRepository> _v_MV_CpteEnComisionRepository;
		public V_MV_CpteEnComisionRepository V_MV_CpteEnComisionRepository {get => _v_MV_CpteEnComisionRepository.Value;}

		private Lazy<V_MV_CpteInsumosRepository> _v_MV_CpteInsumosRepository;
		public V_MV_CpteInsumosRepository V_MV_CpteInsumosRepository {get => _v_MV_CpteInsumosRepository.Value;}

		private Lazy<V_MV_CpteRepository> _v_MV_CpteRepository;
		public V_MV_CpteRepository V_MV_CpteRepository {get => _v_MV_CpteRepository.Value;}

		private Lazy<V_MV_CpteTareasRepository> _v_MV_CpteTareasRepository;
		public V_MV_CpteTareasRepository V_MV_CpteTareasRepository {get => _v_MV_CpteTareasRepository.Value;}

		private Lazy<V_MV_CpteTercerosRepository> _v_MV_CpteTercerosRepository;
		public V_MV_CpteTercerosRepository V_MV_CpteTercerosRepository {get => _v_MV_CpteTercerosRepository.Value;}

		private Lazy<v_mv_creales_AplicacionRepository> _v_mv_creales_AplicacionRepository;
		public v_mv_creales_AplicacionRepository v_mv_creales_AplicacionRepository {get => _v_mv_creales_AplicacionRepository.Value;}

		private Lazy<v_mv_crealesRepository> _v_mv_crealesRepository;
		public v_mv_crealesRepository v_mv_crealesRepository {get => _v_mv_crealesRepository.Value;}

		private Lazy<V_MV_CUOTASRepository> _v_MV_CUOTASRepository;
		public V_MV_CUOTASRepository V_MV_CUOTASRepository {get => _v_MV_CUOTASRepository.Value;}

		private Lazy<V_MV_DiariosRepository> _v_MV_DiariosRepository;
		public V_MV_DiariosRepository V_MV_DiariosRepository {get => _v_MV_DiariosRepository.Value;}

		private Lazy<V_MV_PreciosHisRepository> _v_MV_PreciosHisRepository;
		public V_MV_PreciosHisRepository V_MV_PreciosHisRepository {get => _v_MV_PreciosHisRepository.Value;}

		private Lazy<V_MV_SOLICITUD_ARTICULOSRepository> _v_MV_SOLICITUD_ARTICULOSRepository;
		public V_MV_SOLICITUD_ARTICULOSRepository V_MV_SOLICITUD_ARTICULOSRepository {get => _v_MV_SOLICITUD_ARTICULOSRepository.Value;}

		private Lazy<V_MV_StockRepository> _v_MV_StockRepository;
		public V_MV_StockRepository V_MV_StockRepository {get => _v_MV_StockRepository.Value;}

		private Lazy<V_TA_ALERTAS_STOCKRepository> _v_TA_ALERTAS_STOCKRepository;
		public V_TA_ALERTAS_STOCKRepository V_TA_ALERTAS_STOCKRepository {get => _v_TA_ALERTAS_STOCKRepository.Value;}

		private Lazy<V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository> _v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository;
		public V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository {get => _v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository.Value;}

		private Lazy<V_TA_ATRIBUTOS_PROD_ARTICULOSRepository> _v_TA_ATRIBUTOS_PROD_ARTICULOSRepository;
		public V_TA_ATRIBUTOS_PROD_ARTICULOSRepository V_TA_ATRIBUTOS_PROD_ARTICULOSRepository {get => _v_TA_ATRIBUTOS_PROD_ARTICULOSRepository.Value;}

		private Lazy<V_TA_BancosRepository> _v_TA_BancosRepository;
		public V_TA_BancosRepository V_TA_BancosRepository {get => _v_TA_BancosRepository.Value;}

		private Lazy<V_TA_BONIFICACIONES_COMPRASRepository> _v_TA_BONIFICACIONES_COMPRASRepository;
		public V_TA_BONIFICACIONES_COMPRASRepository V_TA_BONIFICACIONES_COMPRASRepository {get => _v_TA_BONIFICACIONES_COMPRASRepository.Value;}

		private Lazy<V_Ta_CajasRepository> _v_Ta_CajasRepository;
		public V_Ta_CajasRepository V_Ta_CajasRepository {get => _v_Ta_CajasRepository.Value;}

		private Lazy<V_TA_CATALOGOS_HTM_DETALLERepository> _v_TA_CATALOGOS_HTM_DETALLERepository;
		public V_TA_CATALOGOS_HTM_DETALLERepository V_TA_CATALOGOS_HTM_DETALLERepository {get => _v_TA_CATALOGOS_HTM_DETALLERepository.Value;}

		private Lazy<V_TA_CATALOGOS_HTMRepository> _v_TA_CATALOGOS_HTMRepository;
		public V_TA_CATALOGOS_HTMRepository V_TA_CATALOGOS_HTMRepository {get => _v_TA_CATALOGOS_HTMRepository.Value;}

		private Lazy<V_TA_CategoriaRepository> _v_TA_CategoriaRepository;
		public V_TA_CategoriaRepository V_TA_CategoriaRepository {get => _v_TA_CategoriaRepository.Value;}

		private Lazy<V_TA_CLASIFICACION_CREDITICIARepository> _v_TA_CLASIFICACION_CREDITICIARepository;
		public V_TA_CLASIFICACION_CREDITICIARepository V_TA_CLASIFICACION_CREDITICIARepository {get => _v_TA_CLASIFICACION_CREDITICIARepository.Value;}

		private Lazy<V_TA_COMBOS_DETALLERepository> _v_TA_COMBOS_DETALLERepository;
		public V_TA_COMBOS_DETALLERepository V_TA_COMBOS_DETALLERepository {get => _v_TA_COMBOS_DETALLERepository.Value;}

		private Lazy<V_TA_COMBOSRepository> _v_TA_COMBOSRepository;
		public V_TA_COMBOSRepository V_TA_COMBOSRepository {get => _v_TA_COMBOSRepository.Value;}

		private Lazy<V_TA_CONFIG_IMPRESION_CPTESRepository> _v_TA_CONFIG_IMPRESION_CPTESRepository;
		public V_TA_CONFIG_IMPRESION_CPTESRepository V_TA_CONFIG_IMPRESION_CPTESRepository {get => _v_TA_CONFIG_IMPRESION_CPTESRepository.Value;}

		private Lazy<V_TA_Cpra_VtaRepository> _v_TA_Cpra_VtaRepository;
		public V_TA_Cpra_VtaRepository V_TA_Cpra_VtaRepository {get => _v_TA_Cpra_VtaRepository.Value;}

		private Lazy<V_TA_CpteRepository> _v_TA_CpteRepository;
		public V_TA_CpteRepository V_TA_CpteRepository {get => _v_TA_CpteRepository.Value;}

		private Lazy<V_TA_CTRL_CHEQUERASRepository> _v_TA_CTRL_CHEQUERASRepository;
		public V_TA_CTRL_CHEQUERASRepository V_TA_CTRL_CHEQUERASRepository {get => _v_TA_CTRL_CHEQUERASRepository.Value;}

		private Lazy<V_TA_CuentasComisionRepository> _v_TA_CuentasComisionRepository;
		public V_TA_CuentasComisionRepository V_TA_CuentasComisionRepository {get => _v_TA_CuentasComisionRepository.Value;}

		private Lazy<V_TA_DEPOSITO_MMRepository> _v_TA_DEPOSITO_MMRepository;
		public V_TA_DEPOSITO_MMRepository V_TA_DEPOSITO_MMRepository {get => _v_TA_DEPOSITO_MMRepository.Value;}

		private Lazy<V_TA_DEPOSITORepository> _v_TA_DEPOSITORepository;
		public V_TA_DEPOSITORepository V_TA_DEPOSITORepository {get => _v_TA_DEPOSITORepository.Value;}

		private Lazy<V_TA_DESTINORepository> _v_TA_DESTINORepository;
		public V_TA_DESTINORepository V_TA_DESTINORepository {get => _v_TA_DESTINORepository.Value;}

		private Lazy<V_TA_ESCALARETENCIONESRepository> _v_TA_ESCALARETENCIONESRepository;
		public V_TA_ESCALARETENCIONESRepository V_TA_ESCALARETENCIONESRepository {get => _v_TA_ESCALARETENCIONESRepository.Value;}

		private Lazy<V_TA_ESTADO_VISITASRepository> _v_TA_ESTADO_VISITASRepository;
		public V_TA_ESTADO_VISITASRepository V_TA_ESTADO_VISITASRepository {get => _v_TA_ESTADO_VISITASRepository.Value;}

		private Lazy<V_TA_FAMILIASRepository> _v_TA_FAMILIASRepository;
		public V_TA_FAMILIASRepository V_TA_FAMILIASRepository {get => _v_TA_FAMILIASRepository.Value;}

		private Lazy<V_TA_GARANTIASRepository> _v_TA_GARANTIASRepository;
		public V_TA_GARANTIASRepository V_TA_GARANTIASRepository {get => _v_TA_GARANTIASRepository.Value;}

		private Lazy<V_TA_Input_ComprasRepository> _v_TA_Input_ComprasRepository;
		public V_TA_Input_ComprasRepository V_TA_Input_ComprasRepository {get => _v_TA_Input_ComprasRepository.Value;}

		private Lazy<V_TA_Input_VentasRepository> _v_TA_Input_VentasRepository;
		public V_TA_Input_VentasRepository V_TA_Input_VentasRepository {get => _v_TA_Input_VentasRepository.Value;}

		private Lazy<V_TA_Interfaces_asignacionCamposRepository> _v_TA_Interfaces_asignacionCamposRepository;
		public V_TA_Interfaces_asignacionCamposRepository V_TA_Interfaces_asignacionCamposRepository {get => _v_TA_Interfaces_asignacionCamposRepository.Value;}

		private Lazy<V_TA_Interfaces_DetalleRepository> _v_TA_Interfaces_DetalleRepository;
		public V_TA_Interfaces_DetalleRepository V_TA_Interfaces_DetalleRepository {get => _v_TA_Interfaces_DetalleRepository.Value;}

		private Lazy<V_TA_Interfaces_EquivalenciaRepository> _v_TA_Interfaces_EquivalenciaRepository;
		public V_TA_Interfaces_EquivalenciaRepository V_TA_Interfaces_EquivalenciaRepository {get => _v_TA_Interfaces_EquivalenciaRepository.Value;}

		private Lazy<V_TA_INTERFACES_FILTROSRepository> _v_TA_INTERFACES_FILTROSRepository;
		public V_TA_INTERFACES_FILTROSRepository V_TA_INTERFACES_FILTROSRepository {get => _v_TA_INTERFACES_FILTROSRepository.Value;}

		private Lazy<V_TA_INTERFACESRepository> _v_TA_INTERFACESRepository;
		public V_TA_INTERFACESRepository V_TA_INTERFACESRepository {get => _v_TA_INTERFACESRepository.Value;}

		private Lazy<V_TA_MOTIVO_AJUSTESRepository> _v_TA_MOTIVO_AJUSTESRepository;
		public V_TA_MOTIVO_AJUSTESRepository V_TA_MOTIVO_AJUSTESRepository {get => _v_TA_MOTIVO_AJUSTESRepository.Value;}

		private Lazy<V_TA_MOTIVO_BAJA_CUENTASRepository> _v_TA_MOTIVO_BAJA_CUENTASRepository;
		public V_TA_MOTIVO_BAJA_CUENTASRepository V_TA_MOTIVO_BAJA_CUENTASRepository {get => _v_TA_MOTIVO_BAJA_CUENTASRepository.Value;}

		private Lazy<V_TA_MotivoCpraRepository> _v_TA_MotivoCpraRepository;
		public V_TA_MotivoCpraRepository V_TA_MotivoCpraRepository {get => _v_TA_MotivoCpraRepository.Value;}

		private Lazy<V_TA_MOTIVOS_ANULACIONESRepository> _v_TA_MOTIVOS_ANULACIONESRepository;
		public V_TA_MOTIVOS_ANULACIONESRepository V_TA_MOTIVOS_ANULACIONESRepository {get => _v_TA_MOTIVOS_ANULACIONESRepository.Value;}

		private Lazy<V_TA_MotivoStockRepository> _v_TA_MotivoStockRepository;
		public V_TA_MotivoStockRepository V_TA_MotivoStockRepository {get => _v_TA_MotivoStockRepository.Value;}

		private Lazy<V_TA_MotivoVtaRepository> _v_TA_MotivoVtaRepository;
		public V_TA_MotivoVtaRepository V_TA_MotivoVtaRepository {get => _v_TA_MotivoVtaRepository.Value;}

		private Lazy<V_TA_OrigenRepository> _v_TA_OrigenRepository;
		public V_TA_OrigenRepository V_TA_OrigenRepository {get => _v_TA_OrigenRepository.Value;}

		private Lazy<V_TA_PercepcionRepository> _v_TA_PercepcionRepository;
		public V_TA_PercepcionRepository V_TA_PercepcionRepository {get => _v_TA_PercepcionRepository.Value;}

		private Lazy<V_TA_PLANTILLA_FORMULARIOSRepository> _v_TA_PLANTILLA_FORMULARIOSRepository;
		public V_TA_PLANTILLA_FORMULARIOSRepository V_TA_PLANTILLA_FORMULARIOSRepository {get => _v_TA_PLANTILLA_FORMULARIOSRepository.Value;}

		private Lazy<V_TA_PoliticaPreciosRepository> _v_TA_PoliticaPreciosRepository;
		public V_TA_PoliticaPreciosRepository V_TA_PoliticaPreciosRepository {get => _v_TA_PoliticaPreciosRepository.Value;}

		private Lazy<V_TA_PROCESOS_PRODUCTIVOSRepository> _v_TA_PROCESOS_PRODUCTIVOSRepository;
		public V_TA_PROCESOS_PRODUCTIVOSRepository V_TA_PROCESOS_PRODUCTIVOSRepository {get => _v_TA_PROCESOS_PRODUCTIVOSRepository.Value;}

		private Lazy<V_TA_REPORTES_PERSONALIZADOS_DETALLERepository> _v_TA_REPORTES_PERSONALIZADOS_DETALLERepository;
		public V_TA_REPORTES_PERSONALIZADOS_DETALLERepository V_TA_REPORTES_PERSONALIZADOS_DETALLERepository {get => _v_TA_REPORTES_PERSONALIZADOS_DETALLERepository.Value;}

		private Lazy<V_TA_REPORTES_PERSONALIZADOSRepository> _v_TA_REPORTES_PERSONALIZADOSRepository;
		public V_TA_REPORTES_PERSONALIZADOSRepository V_TA_REPORTES_PERSONALIZADOSRepository {get => _v_TA_REPORTES_PERSONALIZADOSRepository.Value;}

		private Lazy<V_TA_RETENCIONESRepository> _v_TA_RETENCIONESRepository;
		public V_TA_RETENCIONESRepository V_TA_RETENCIONESRepository {get => _v_TA_RETENCIONESRepository.Value;}

		private Lazy<V_TA_RubrosRepository> _v_TA_RubrosRepository;
		public V_TA_RubrosRepository V_TA_RubrosRepository {get => _v_TA_RubrosRepository.Value;}

		private Lazy<V_TA_SECTORESRepository> _v_TA_SECTORESRepository;
		public V_TA_SECTORESRepository V_TA_SECTORESRepository {get => _v_TA_SECTORESRepository.Value;}

		private Lazy<V_TA_STATUS_NPRepository> _v_TA_STATUS_NPRepository;
		public V_TA_STATUS_NPRepository V_TA_STATUS_NPRepository {get => _v_TA_STATUS_NPRepository.Value;}

		private Lazy<V_TA_STATUS_OPRepository> _v_TA_STATUS_OPRepository;
		public V_TA_STATUS_OPRepository V_TA_STATUS_OPRepository {get => _v_TA_STATUS_OPRepository.Value;}

		private Lazy<V_TA_SUCURSALESRepository> _v_TA_SUCURSALESRepository;
		public V_TA_SUCURSALESRepository V_TA_SUCURSALESRepository {get => _v_TA_SUCURSALESRepository.Value;}

		private Lazy<V_TA_TareasRepository> _v_TA_TareasRepository;
		public V_TA_TareasRepository V_TA_TareasRepository {get => _v_TA_TareasRepository.Value;}

		private Lazy<V_TA_TecnicosRepository> _v_TA_TecnicosRepository;
		public V_TA_TecnicosRepository V_TA_TecnicosRepository {get => _v_TA_TecnicosRepository.Value;}

		private Lazy<V_TA_TEMPORADASRepository> _v_TA_TEMPORADASRepository;
		public V_TA_TEMPORADASRepository V_TA_TEMPORADASRepository {get => _v_TA_TEMPORADASRepository.Value;}

		private Lazy<V_TA_TipoArticuloRepository> _v_TA_TipoArticuloRepository;
		public V_TA_TipoArticuloRepository V_TA_TipoArticuloRepository {get => _v_TA_TipoArticuloRepository.Value;}

		private Lazy<V_TA_UnidadRepository> _v_TA_UnidadRepository;
		public V_TA_UnidadRepository V_TA_UnidadRepository {get => _v_TA_UnidadRepository.Value;}

		private Lazy<V_TA_VENDEDORES_ALERTASRepository> _v_TA_VENDEDORES_ALERTASRepository;
		public V_TA_VENDEDORES_ALERTASRepository V_TA_VENDEDORES_ALERTASRepository {get => _v_TA_VENDEDORES_ALERTASRepository.Value;}

		private Lazy<V_TA_VENDEDORESRepository> _v_TA_VENDEDORESRepository;
		public V_TA_VENDEDORESRepository V_TA_VENDEDORESRepository {get => _v_TA_VENDEDORESRepository.Value;}

		private Lazy<V_TA_ZONASRepository> _v_TA_ZONASRepository;
		public V_TA_ZONASRepository V_TA_ZONASRepository {get => _v_TA_ZONASRepository.Value;}


		//ViewManagers
		private Lazy<AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager> _aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager;
		public AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager {get => _aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager.Value;}

		private Lazy<AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager> _aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager;
		public AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager {get => _aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager.Value;}

		private Lazy<AUX_MV_CPTE_COBRANZASViewManager> _aUX_MV_CPTE_COBRANZASViewManager;
		public AUX_MV_CPTE_COBRANZASViewManager AUX_MV_CPTE_COBRANZASViewManager {get => _aUX_MV_CPTE_COBRANZASViewManager.Value;}

		private Lazy<AuxObtieneNetoViewManager> _auxObtieneNetoViewManager;
		public AuxObtieneNetoViewManager AuxObtieneNetoViewManager {get => _auxObtieneNetoViewManager.Value;}

		private Lazy<C_BusquedaPreciosProveedorDtoCpraViewManager> _c_BusquedaPreciosProveedorDtoCpraViewManager;
		public C_BusquedaPreciosProveedorDtoCpraViewManager C_BusquedaPreciosProveedorDtoCpraViewManager {get => _c_BusquedaPreciosProveedorDtoCpraViewManager.Value;}

		private Lazy<C_MV_CPTE_RANKING_CONSUMOViewManager> _c_MV_CPTE_RANKING_CONSUMOViewManager;
		public C_MV_CPTE_RANKING_CONSUMOViewManager C_MV_CPTE_RANKING_CONSUMOViewManager {get => _c_MV_CPTE_RANKING_CONSUMOViewManager.Value;}

		private Lazy<C_RemitosConCobranzasViewManager> _c_RemitosConCobranzasViewManager;
		public C_RemitosConCobranzasViewManager C_RemitosConCobranzasViewManager {get => _c_RemitosConCobranzasViewManager.Value;}

		private Lazy<C_RemitosFacturadosViewManager> _c_RemitosFacturadosViewManager;
		public C_RemitosFacturadosViewManager C_RemitosFacturadosViewManager {get => _c_RemitosFacturadosViewManager.Value;}

		private Lazy<C_RemitosPendientesSinProveedorViewManager> _c_RemitosPendientesSinProveedorViewManager;
		public C_RemitosPendientesSinProveedorViewManager C_RemitosPendientesSinProveedorViewManager {get => _c_RemitosPendientesSinProveedorViewManager.Value;}

		private Lazy<c_RemitosPendientesViewManager> _c_RemitosPendientesViewManager;
		public c_RemitosPendientesViewManager c_RemitosPendientesViewManager {get => _c_RemitosPendientesViewManager.Value;}

		private Lazy<C_RemitosSinAplicacionViewManager> _c_RemitosSinAplicacionViewManager;
		public C_RemitosSinAplicacionViewManager C_RemitosSinAplicacionViewManager {get => _c_RemitosSinAplicacionViewManager.Value;}

		private Lazy<ChequesFirmadosNoConciliadosViewManager> _chequesFirmadosNoConciliadosViewManager;
		public ChequesFirmadosNoConciliadosViewManager ChequesFirmadosNoConciliadosViewManager {get => _chequesFirmadosNoConciliadosViewManager.Value;}

		private Lazy<CO_AplicacionOCViewManager> _cO_AplicacionOCViewManager;
		public CO_AplicacionOCViewManager CO_AplicacionOCViewManager {get => _cO_AplicacionOCViewManager.Value;}

		private Lazy<CO_CPTES_CREDITOS_PENDIENTESViewManager> _cO_CPTES_CREDITOS_PENDIENTESViewManager;
		public CO_CPTES_CREDITOS_PENDIENTESViewManager CO_CPTES_CREDITOS_PENDIENTESViewManager {get => _cO_CPTES_CREDITOS_PENDIENTESViewManager.Value;}

		private Lazy<CO_CPTES_IMPAGOSViewManager> _cO_CPTES_IMPAGOSViewManager;
		public CO_CPTES_IMPAGOSViewManager CO_CPTES_IMPAGOSViewManager {get => _cO_CPTES_IMPAGOSViewManager.Value;}

		private Lazy<CO_FaltantesOCViewManager> _cO_FaltantesOCViewManager;
		public CO_FaltantesOCViewManager CO_FaltantesOCViewManager {get => _cO_FaltantesOCViewManager.Value;}

		private Lazy<CO_FCCore_PendientesViewManager> _cO_FCCore_PendientesViewManager;
		public CO_FCCore_PendientesViewManager CO_FCCore_PendientesViewManager {get => _cO_FCCore_PendientesViewManager.Value;}

		private Lazy<CO_OCompraPendientes_DetalleViewManager> _cO_OCompraPendientes_DetalleViewManager;
		public CO_OCompraPendientes_DetalleViewManager CO_OCompraPendientes_DetalleViewManager {get => _cO_OCompraPendientes_DetalleViewManager.Value;}

		private Lazy<CO_OCompraPendientesViewManager> _cO_OCompraPendientesViewManager;
		public CO_OCompraPendientesViewManager CO_OCompraPendientesViewManager {get => _cO_OCompraPendientesViewManager.Value;}

		private Lazy<GM_PLANILLASViewManager> _gM_PLANILLASViewManager;
		public GM_PLANILLASViewManager GM_PLANILLASViewManager {get => _gM_PLANILLASViewManager.Value;}

		private Lazy<LibroIvaComprasViewManager> _libroIvaComprasViewManager;
		public LibroIvaComprasViewManager LibroIvaComprasViewManager {get => _libroIvaComprasViewManager.Value;}

		private Lazy<LibroIvaVentasDirecto_ConsignadoViewManager> _libroIvaVentasDirecto_ConsignadoViewManager;
		public LibroIvaVentasDirecto_ConsignadoViewManager LibroIvaVentasDirecto_ConsignadoViewManager {get => _libroIvaVentasDirecto_ConsignadoViewManager.Value;}

		private Lazy<LibroIvaVentasPorPeriodoViewManager> _libroIvaVentasPorPeriodoViewManager;
		public LibroIvaVentasPorPeriodoViewManager LibroIvaVentasPorPeriodoViewManager {get => _libroIvaVentasPorPeriodoViewManager.Value;}

		private Lazy<LibroIvaVentasResumenViewManager> _libroIvaVentasResumenViewManager;
		public LibroIvaVentasResumenViewManager LibroIvaVentasResumenViewManager {get => _libroIvaVentasResumenViewManager.Value;}

		private Lazy<LibroIvaVentasViewManager> _libroIvaVentasViewManager;
		public LibroIvaVentasViewManager LibroIvaVentasViewManager {get => _libroIvaVentasViewManager.Value;}

		private Lazy<NW_DOCUMENTADORViewManager> _nW_DOCUMENTADORViewManager;
		public NW_DOCUMENTADORViewManager NW_DOCUMENTADORViewManager {get => _nW_DOCUMENTADORViewManager.Value;}

		private Lazy<P_AUX_LEGAJOSViewManager> _p_AUX_LEGAJOSViewManager;
		public P_AUX_LEGAJOSViewManager P_AUX_LEGAJOSViewManager {get => _p_AUX_LEGAJOSViewManager.Value;}

		private Lazy<P_ENTREVISTASEVALUACIONESViewManager> _p_ENTREVISTASEVALUACIONESViewManager;
		public P_ENTREVISTASEVALUACIONESViewManager P_ENTREVISTASEVALUACIONESViewManager {get => _p_ENTREVISTASEVALUACIONESViewManager.Value;}

		private Lazy<P_EntrevistasFHViewManager> _p_EntrevistasFHViewManager;
		public P_EntrevistasFHViewManager P_EntrevistasFHViewManager {get => _p_EntrevistasFHViewManager.Value;}

		private Lazy<P_EntrevistasPendientesFhViewManager> _p_EntrevistasPendientesFhViewManager;
		public P_EntrevistasPendientesFhViewManager P_EntrevistasPendientesFhViewManager {get => _p_EntrevistasPendientesFhViewManager.Value;}

		private Lazy<P_EntrevistasPendientesViewManager> _p_EntrevistasPendientesViewManager;
		public P_EntrevistasPendientesViewManager P_EntrevistasPendientesViewManager {get => _p_EntrevistasPendientesViewManager.Value;}

		private Lazy<P_EntrevistasViewManager> _p_EntrevistasViewManager;
		public P_EntrevistasViewManager P_EntrevistasViewManager {get => _p_EntrevistasViewManager.Value;}

		private Lazy<P_EvaluacionesPendientesViewManager> _p_EvaluacionesPendientesViewManager;
		public P_EvaluacionesPendientesViewManager P_EvaluacionesPendientesViewManager {get => _p_EvaluacionesPendientesViewManager.Value;}

		private Lazy<P_EvaluacionesViewManager> _p_EvaluacionesViewManager;
		public P_EvaluacionesViewManager P_EvaluacionesViewManager {get => _p_EvaluacionesViewManager.Value;}

		private Lazy<P_SaldosClientesBusquedasViewManager> _p_SaldosClientesBusquedasViewManager;
		public P_SaldosClientesBusquedasViewManager P_SaldosClientesBusquedasViewManager {get => _p_SaldosClientesBusquedasViewManager.Value;}

		private Lazy<P_SaldosClientesViewManager> _p_SaldosClientesViewManager;
		public P_SaldosClientesViewManager P_SaldosClientesViewManager {get => _p_SaldosClientesViewManager.Value;}

		private Lazy<P_Sind_CategoriasViewManager> _p_Sind_CategoriasViewManager;
		public P_Sind_CategoriasViewManager P_Sind_CategoriasViewManager {get => _p_Sind_CategoriasViewManager.Value;}

		private Lazy<P_SindCatCargosViewManager> _p_SindCatCargosViewManager;
		public P_SindCatCargosViewManager P_SindCatCargosViewManager {get => _p_SindCatCargosViewManager.Value;}

		private Lazy<P_SindicatosViewManager> _p_SindicatosViewManager;
		public P_SindicatosViewManager P_SindicatosViewManager {get => _p_SindicatosViewManager.Value;}

		private Lazy<P_SolucitudesAFinalizarViewManager> _p_SolucitudesAFinalizarViewManager;
		public P_SolucitudesAFinalizarViewManager P_SolucitudesAFinalizarViewManager {get => _p_SolucitudesAFinalizarViewManager.Value;}

		private Lazy<P_SolucitudesPostulantesViewManager> _p_SolucitudesPostulantesViewManager;
		public P_SolucitudesPostulantesViewManager P_SolucitudesPostulantesViewManager {get => _p_SolucitudesPostulantesViewManager.Value;}

		private Lazy<P_SolucitudesViewManager> _p_SolucitudesViewManager;
		public P_SolucitudesViewManager P_SolucitudesViewManager {get => _p_SolucitudesViewManager.Value;}

		private Lazy<P_TodasLasSolicitudesPostulantesViewManager> _p_TodasLasSolicitudesPostulantesViewManager;
		public P_TodasLasSolicitudesPostulantesViewManager P_TodasLasSolicitudesPostulantesViewManager {get => _p_TodasLasSolicitudesPostulantesViewManager.Value;}

		private Lazy<P_TodasLasSolicitudesPostViewManager> _p_TodasLasSolicitudesPostViewManager;
		public P_TodasLasSolicitudesPostViewManager P_TodasLasSolicitudesPostViewManager {get => _p_TodasLasSolicitudesPostViewManager.Value;}

		private Lazy<P_TodasLasSolicitudesViewManager> _p_TodasLasSolicitudesViewManager;
		public P_TodasLasSolicitudesViewManager P_TodasLasSolicitudesViewManager {get => _p_TodasLasSolicitudesViewManager.Value;}

		private Lazy<RANKING_CONSUMOViewManager> _rANKING_CONSUMOViewManager;
		public RANKING_CONSUMOViewManager RANKING_CONSUMOViewManager {get => _rANKING_CONSUMOViewManager.Value;}

		private Lazy<Stk_Ma_ArticulosViewManager> _stk_Ma_ArticulosViewManager;
		public Stk_Ma_ArticulosViewManager Stk_Ma_ArticulosViewManager {get => _stk_Ma_ArticulosViewManager.Value;}

		private Lazy<STK_PuntoReposicionViewManager> _sTK_PuntoReposicionViewManager;
		public STK_PuntoReposicionViewManager STK_PuntoReposicionViewManager {get => _sTK_PuntoReposicionViewManager.Value;}

		private Lazy<STK_SALDOS_ART_CON_TROPAViewManager> _sTK_SALDOS_ART_CON_TROPAViewManager;
		public STK_SALDOS_ART_CON_TROPAViewManager STK_SALDOS_ART_CON_TROPAViewManager {get => _sTK_SALDOS_ART_CON_TROPAViewManager.Value;}

		private Lazy<STK_SALDOS_SLViewManager> _sTK_SALDOS_SLViewManager;
		public STK_SALDOS_SLViewManager STK_SALDOS_SLViewManager {get => _sTK_SALDOS_SLViewManager.Value;}

		private Lazy<STK_SALDOS_UnidadesViewManager> _sTK_SALDOS_UnidadesViewManager;
		public STK_SALDOS_UnidadesViewManager STK_SALDOS_UnidadesViewManager {get => _sTK_SALDOS_UnidadesViewManager.Value;}

		private Lazy<STK_SERIES_Y_LOTESViewManager> _sTK_SERIES_Y_LOTESViewManager;
		public STK_SERIES_Y_LOTESViewManager STK_SERIES_Y_LOTESViewManager {get => _sTK_SERIES_Y_LOTESViewManager.Value;}

		private Lazy<STK_STOCK_EQUIVViewManager> _sTK_STOCK_EQUIVViewManager;
		public STK_STOCK_EQUIVViewManager STK_STOCK_EQUIVViewManager {get => _sTK_STOCK_EQUIVViewManager.Value;}

		private Lazy<SW_DOCUMENTADORViewManager> _sW_DOCUMENTADORViewManager;
		public SW_DOCUMENTADORViewManager SW_DOCUMENTADORViewManager {get => _sW_DOCUMENTADORViewManager.Value;}

		private Lazy<SW_TABLAS_CON_CAMPOSViewManager> _sW_TABLAS_CON_CAMPOSViewManager;
		public SW_TABLAS_CON_CAMPOSViewManager SW_TABLAS_CON_CAMPOSViewManager {get => _sW_TABLAS_CON_CAMPOSViewManager.Value;}

		private Lazy<SW_TABLAS_SISTEMAViewManager> _sW_TABLAS_SISTEMAViewManager;
		public SW_TABLAS_SISTEMAViewManager SW_TABLAS_SISTEMAViewManager {get => _sW_TABLAS_SISTEMAViewManager.Value;}

		private Lazy<tmp_cuotasViewManager> _tmp_cuotasViewManager;
		public tmp_cuotasViewManager tmp_cuotasViewManager {get => _tmp_cuotasViewManager.Value;}

		private Lazy<V_Aplicacion_OrdenDePagoViewManager> _v_Aplicacion_OrdenDePagoViewManager;
		public V_Aplicacion_OrdenDePagoViewManager V_Aplicacion_OrdenDePagoViewManager {get => _v_Aplicacion_OrdenDePagoViewManager.Value;}

		private Lazy<V_AsientosCCostoViewManager> _v_AsientosCCostoViewManager;
		public V_AsientosCCostoViewManager V_AsientosCCostoViewManager {get => _v_AsientosCCostoViewManager.Value;}

		private Lazy<v_chequesconciliadosViewManager> _v_chequesconciliadosViewManager;
		public v_chequesconciliadosViewManager v_chequesconciliadosViewManager {get => _v_chequesconciliadosViewManager.Value;}

		private Lazy<V_ChequesEnCarteraViewManager> _v_ChequesEnCarteraViewManager;
		public V_ChequesEnCarteraViewManager V_ChequesEnCarteraViewManager {get => _v_ChequesEnCarteraViewManager.Value;}

		private Lazy<V_ChequesEntregadosViewManager> _v_ChequesEntregadosViewManager;
		public V_ChequesEntregadosViewManager V_ChequesEntregadosViewManager {get => _v_ChequesEntregadosViewManager.Value;}

		private Lazy<V_ChequesFirmadosNoConciliadosViewManager> _v_ChequesFirmadosNoConciliadosViewManager;
		public V_ChequesFirmadosNoConciliadosViewManager V_ChequesFirmadosNoConciliadosViewManager {get => _v_ChequesFirmadosNoConciliadosViewManager.Value;}

		private Lazy<V_ChequesFirmadosViewManager> _v_ChequesFirmadosViewManager;
		public V_ChequesFirmadosViewManager V_ChequesFirmadosViewManager {get => _v_ChequesFirmadosViewManager.Value;}

		private Lazy<V_ChequesRecibidosViewManager> _v_ChequesRecibidosViewManager;
		public V_ChequesRecibidosViewManager V_ChequesRecibidosViewManager {get => _v_ChequesRecibidosViewManager.Value;}

		private Lazy<V_COBRANZASPORUSUARIOViewManager> _v_COBRANZASPORUSUARIOViewManager;
		public V_COBRANZASPORUSUARIOViewManager V_COBRANZASPORUSUARIOViewManager {get => _v_COBRANZASPORUSUARIOViewManager.Value;}

		private Lazy<V_ConsultaDeRubroTipoProveedorViewManager> _v_ConsultaDeRubroTipoProveedorViewManager;
		public V_ConsultaDeRubroTipoProveedorViewManager V_ConsultaDeRubroTipoProveedorViewManager {get => _v_ConsultaDeRubroTipoProveedorViewManager.Value;}

		private Lazy<V_ConsultaDeRubroTipoProveerdorArticulosViewManager> _v_ConsultaDeRubroTipoProveerdorArticulosViewManager;
		public V_ConsultaDeRubroTipoProveerdorArticulosViewManager V_ConsultaDeRubroTipoProveerdorArticulosViewManager {get => _v_ConsultaDeRubroTipoProveerdorArticulosViewManager.Value;}

		private Lazy<V_EstadoBancarioViewManager> _v_EstadoBancarioViewManager;
		public V_EstadoBancarioViewManager V_EstadoBancarioViewManager {get => _v_EstadoBancarioViewManager.Value;}

		private Lazy<V_ImportesAplicadosViewManager> _v_ImportesAplicadosViewManager;
		public V_ImportesAplicadosViewManager V_ImportesAplicadosViewManager {get => _v_ImportesAplicadosViewManager.Value;}

		private Lazy<V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager> _v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager;
		public V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager {get => _v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager.Value;}

		private Lazy<v_mv_CargosAplicadosViewManager> _v_mv_CargosAplicadosViewManager;
		public v_mv_CargosAplicadosViewManager v_mv_CargosAplicadosViewManager {get => _v_mv_CargosAplicadosViewManager.Value;}

		private Lazy<V_NP_PENDIENTES_COMPROMETIDOViewManager> _v_NP_PENDIENTES_COMPROMETIDOViewManager;
		public V_NP_PENDIENTES_COMPROMETIDOViewManager V_NP_PENDIENTES_COMPROMETIDOViewManager {get => _v_NP_PENDIENTES_COMPROMETIDOViewManager.Value;}

		private Lazy<V_NP_PENDIENTES2ViewManager> _v_NP_PENDIENTES2ViewManager;
		public V_NP_PENDIENTES2ViewManager V_NP_PENDIENTES2ViewManager {get => _v_NP_PENDIENTES2ViewManager.Value;}

		private Lazy<V_NP_PendientesViewManager> _v_NP_PendientesViewManager;
		public V_NP_PendientesViewManager V_NP_PendientesViewManager {get => _v_NP_PendientesViewManager.Value;}

		private Lazy<V_OF_PENDIENTESViewManager> _v_OF_PENDIENTESViewManager;
		public V_OF_PENDIENTESViewManager V_OF_PENDIENTESViewManager {get => _v_OF_PENDIENTESViewManager.Value;}

		private Lazy<V_OT_PendientesViewManager> _v_OT_PendientesViewManager;
		public V_OT_PendientesViewManager V_OT_PendientesViewManager {get => _v_OT_PendientesViewManager.Value;}

		private Lazy<V_PR_PendientesViewManager> _v_PR_PendientesViewManager;
		public V_PR_PendientesViewManager V_PR_PendientesViewManager {get => _v_PR_PendientesViewManager.Value;}

		private Lazy<V_RemitosConCobranzasViewManager> _v_RemitosConCobranzasViewManager;
		public V_RemitosConCobranzasViewManager V_RemitosConCobranzasViewManager {get => _v_RemitosConCobranzasViewManager.Value;}

		private Lazy<V_RemitosFacturadosViewManager> _v_RemitosFacturadosViewManager;
		public V_RemitosFacturadosViewManager V_RemitosFacturadosViewManager {get => _v_RemitosFacturadosViewManager.Value;}

		private Lazy<V_RemitosPendientesViewManager> _v_RemitosPendientesViewManager;
		public V_RemitosPendientesViewManager V_RemitosPendientesViewManager {get => _v_RemitosPendientesViewManager.Value;}

		private Lazy<V_RemitosSinAplicacionViewManager> _v_RemitosSinAplicacionViewManager;
		public V_RemitosSinAplicacionViewManager V_RemitosSinAplicacionViewManager {get => _v_RemitosSinAplicacionViewManager.Value;}

		private Lazy<VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager> _vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager;
		public VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager {get => _vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager.Value;}

		private Lazy<VE_CPTES_CREDITOS_PENDIENTESViewManager> _vE_CPTES_CREDITOS_PENDIENTESViewManager;
		public VE_CPTES_CREDITOS_PENDIENTESViewManager VE_CPTES_CREDITOS_PENDIENTESViewManager {get => _vE_CPTES_CREDITOS_PENDIENTESViewManager.Value;}

		private Lazy<VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager> _vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager;
		public VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager {get => _vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager.Value;}

		private Lazy<VE_CPTES_IMPAGOSViewManager> _vE_CPTES_IMPAGOSViewManager;
		public VE_CPTES_IMPAGOSViewManager VE_CPTES_IMPAGOSViewManager {get => _vE_CPTES_IMPAGOSViewManager.Value;}

		private Lazy<VE_CPTES_SALDOS_HABERViewManager> _vE_CPTES_SALDOS_HABERViewManager;
		public VE_CPTES_SALDOS_HABERViewManager VE_CPTES_SALDOS_HABERViewManager {get => _vE_CPTES_SALDOS_HABERViewManager.Value;}

		private Lazy<VE_CPTES_SALDOSViewManager> _vE_CPTES_SALDOSViewManager;
		public VE_CPTES_SALDOSViewManager VE_CPTES_SALDOSViewManager {get => _vE_CPTES_SALDOSViewManager.Value;}

		private Lazy<VE_SALDOAPLICACION_HABERViewManager> _vE_SALDOAPLICACION_HABERViewManager;
		public VE_SALDOAPLICACION_HABERViewManager VE_SALDOAPLICACION_HABERViewManager {get => _vE_SALDOAPLICACION_HABERViewManager.Value;}

		private Lazy<VE_SALDOAPLICACIONViewManager> _vE_SALDOAPLICACIONViewManager;
		public VE_SALDOAPLICACIONViewManager VE_SALDOAPLICACIONViewManager {get => _vE_SALDOAPLICACIONViewManager.Value;}

		private Lazy<VE_SALDOSCTA_DEBEViewManager> _vE_SALDOSCTA_DEBEViewManager;
		public VE_SALDOSCTA_DEBEViewManager VE_SALDOSCTA_DEBEViewManager {get => _vE_SALDOSCTA_DEBEViewManager.Value;}

		private Lazy<VE_SALDOSCTA_HABERViewManager> _vE_SALDOSCTA_HABERViewManager;
		public VE_SALDOSCTA_HABERViewManager VE_SALDOSCTA_HABERViewManager {get => _vE_SALDOSCTA_HABERViewManager.Value;}

		private Lazy<VE_SALDOSCTAViewManager> _vE_SALDOSCTAViewManager;
		public VE_SALDOSCTAViewManager VE_SALDOSCTAViewManager {get => _vE_SALDOSCTAViewManager.Value;}

		private Lazy<VE_SALDOSVDOR_DEBEViewManager> _vE_SALDOSVDOR_DEBEViewManager;
		public VE_SALDOSVDOR_DEBEViewManager VE_SALDOSVDOR_DEBEViewManager {get => _vE_SALDOSVDOR_DEBEViewManager.Value;}

		private Lazy<VE_SALDOSVDOR_HABERViewManager> _vE_SALDOSVDOR_HABERViewManager;
		public VE_SALDOSVDOR_HABERViewManager VE_SALDOSVDOR_HABERViewManager {get => _vE_SALDOSVDOR_HABERViewManager.Value;}

		private Lazy<VE_SALDOSVDORViewManager> _vE_SALDOSVDORViewManager;
		public VE_SALDOSVDORViewManager VE_SALDOSVDORViewManager {get => _vE_SALDOSVDORViewManager.Value;}

		private Lazy<VT_C_MV_INSUMOS_APLICACIONViewManager> _vT_C_MV_INSUMOS_APLICACIONViewManager;
		public VT_C_MV_INSUMOS_APLICACIONViewManager VT_C_MV_INSUMOS_APLICACIONViewManager {get => _vT_C_MV_INSUMOS_APLICACIONViewManager.Value;}

		private Lazy<Vt_ClientesViewManager> _vt_ClientesViewManager;
		public Vt_ClientesViewManager Vt_ClientesViewManager {get => _vt_ClientesViewManager.Value;}

		private Lazy<VT_CO_CPTE_DiferidoViewManager> _vT_CO_CPTE_DiferidoViewManager;
		public VT_CO_CPTE_DiferidoViewManager VT_CO_CPTE_DiferidoViewManager {get => _vT_CO_CPTE_DiferidoViewManager.Value;}

		private Lazy<VT_COBRANZASViewManager> _vT_COBRANZASViewManager;
		public VT_COBRANZASViewManager VT_COBRANZASViewManager {get => _vT_COBRANZASViewManager.Value;}

		private Lazy<VT_CPTE_DiferidoViewManager> _vT_CPTE_DiferidoViewManager;
		public VT_CPTE_DiferidoViewManager VT_CPTE_DiferidoViewManager {get => _vT_CPTE_DiferidoViewManager.Value;}

		private Lazy<VT_DEPOSITO_MM_STOCKViewManager> _vT_DEPOSITO_MM_STOCKViewManager;
		public VT_DEPOSITO_MM_STOCKViewManager VT_DEPOSITO_MM_STOCKViewManager {get => _vT_DEPOSITO_MM_STOCKViewManager.Value;}

		private Lazy<VT_DEPOSITO_MMViewManager> _vT_DEPOSITO_MMViewManager;
		public VT_DEPOSITO_MMViewManager VT_DEPOSITO_MMViewManager {get => _vT_DEPOSITO_MMViewManager.Value;}

		private Lazy<VT_ESTADISTICA_CLIENTES_COBRANZASViewManager> _vT_ESTADISTICA_CLIENTES_COBRANZASViewManager;
		public VT_ESTADISTICA_CLIENTES_COBRANZASViewManager VT_ESTADISTICA_CLIENTES_COBRANZASViewManager {get => _vT_ESTADISTICA_CLIENTES_COBRANZASViewManager.Value;}

		private Lazy<VT_ESTADISTICA_CLIENTES_ENTREGASViewManager> _vT_ESTADISTICA_CLIENTES_ENTREGASViewManager;
		public VT_ESTADISTICA_CLIENTES_ENTREGASViewManager VT_ESTADISTICA_CLIENTES_ENTREGASViewManager {get => _vT_ESTADISTICA_CLIENTES_ENTREGASViewManager.Value;}

		private Lazy<VT_ESTADISTICA_CLIENTESViewManager> _vT_ESTADISTICA_CLIENTESViewManager;
		public VT_ESTADISTICA_CLIENTESViewManager VT_ESTADISTICA_CLIENTESViewManager {get => _vT_ESTADISTICA_CLIENTESViewManager.Value;}

		private Lazy<VT_MA_PRECIOS_ARTICULOSViewManager> _vT_MA_PRECIOS_ARTICULOSViewManager;
		public VT_MA_PRECIOS_ARTICULOSViewManager VT_MA_PRECIOS_ARTICULOSViewManager {get => _vT_MA_PRECIOS_ARTICULOSViewManager.Value;}

		private Lazy<VT_MA_PRECIOSViewManager> _vT_MA_PRECIOSViewManager;
		public VT_MA_PRECIOSViewManager VT_MA_PRECIOSViewManager {get => _vT_MA_PRECIOSViewManager.Value;}

		private Lazy<VT_MAX_NRO_CPTE_ASIENTOSViewManager> _vT_MAX_NRO_CPTE_ASIENTOSViewManager;
		public VT_MAX_NRO_CPTE_ASIENTOSViewManager VT_MAX_NRO_CPTE_ASIENTOSViewManager {get => _vT_MAX_NRO_CPTE_ASIENTOSViewManager.Value;}

		private Lazy<VT_MV_APLICACIONViewManager> _vT_MV_APLICACIONViewManager;
		public VT_MV_APLICACIONViewManager VT_MV_APLICACIONViewManager {get => _vT_MV_APLICACIONViewManager.Value;}

		private Lazy<VT_MV_CUOTAS_IMPAGASViewManager> _vT_MV_CUOTAS_IMPAGASViewManager;
		public VT_MV_CUOTAS_IMPAGASViewManager VT_MV_CUOTAS_IMPAGASViewManager {get => _vT_MV_CUOTAS_IMPAGASViewManager.Value;}

		private Lazy<VT_MV_CUOTAS_PAGASViewManager> _vT_MV_CUOTAS_PAGASViewManager;
		public VT_MV_CUOTAS_PAGASViewManager VT_MV_CUOTAS_PAGASViewManager {get => _vT_MV_CUOTAS_PAGASViewManager.Value;}

		private Lazy<VT_MV_Diarios_DescripViewManager> _vT_MV_Diarios_DescripViewManager;
		public VT_MV_Diarios_DescripViewManager VT_MV_Diarios_DescripViewManager {get => _vT_MV_Diarios_DescripViewManager.Value;}

		private Lazy<VT_PLANILLASMovilesViewManager> _vT_PLANILLASMovilesViewManager;
		public VT_PLANILLASMovilesViewManager VT_PLANILLASMovilesViewManager {get => _vT_PLANILLASMovilesViewManager.Value;}

		private Lazy<Vt_ProveedoresViewManager> _vt_ProveedoresViewManager;
		public Vt_ProveedoresViewManager Vt_ProveedoresViewManager {get => _vt_ProveedoresViewManager.Value;}

		private Lazy<VT_RankingConsumo_ClienteViewManager> _vT_RankingConsumo_ClienteViewManager;
		public VT_RankingConsumo_ClienteViewManager VT_RankingConsumo_ClienteViewManager {get => _vT_RankingConsumo_ClienteViewManager.Value;}

		private Lazy<VT_RankingConsumoViewManager> _vT_RankingConsumoViewManager;
		public VT_RankingConsumoViewManager VT_RankingConsumoViewManager {get => _vT_RankingConsumoViewManager.Value;}

		private Lazy<VT_RubroTipoArticulosDescripcionesViewManager> _vT_RubroTipoArticulosDescripcionesViewManager;
		public VT_RubroTipoArticulosDescripcionesViewManager VT_RubroTipoArticulosDescripcionesViewManager {get => _vT_RubroTipoArticulosDescripcionesViewManager.Value;}

		private Lazy<VT_RubroTipoDescripcionesViewManager> _vT_RubroTipoDescripcionesViewManager;
		public VT_RubroTipoDescripcionesViewManager VT_RubroTipoDescripcionesViewManager {get => _vT_RubroTipoDescripcionesViewManager.Value;}

		private Lazy<VT_TA_PLANTILLAS_FORMULARIOSViewManager> _vT_TA_PLANTILLAS_FORMULARIOSViewManager;
		public VT_TA_PLANTILLAS_FORMULARIOSViewManager VT_TA_PLANTILLAS_FORMULARIOSViewManager {get => _vT_TA_PLANTILLAS_FORMULARIOSViewManager.Value;}

		private Lazy<VT_ULTIMOS_PRECIOS_COMPRAViewManager> _vT_ULTIMOS_PRECIOS_COMPRAViewManager;
		public VT_ULTIMOS_PRECIOS_COMPRAViewManager VT_ULTIMOS_PRECIOS_COMPRAViewManager {get => _vT_ULTIMOS_PRECIOS_COMPRAViewManager.Value;}

		private Lazy<VT_ULTIMOS_PRECIOS_VENTAViewManager> _vT_ULTIMOS_PRECIOS_VENTAViewManager;
		public VT_ULTIMOS_PRECIOS_VENTAViewManager VT_ULTIMOS_PRECIOS_VENTAViewManager {get => _vT_ULTIMOS_PRECIOS_VENTAViewManager.Value;}

		private Lazy<VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager> _vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager;
		public VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager {get => _vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager.Value;}

		private Lazy<VT_V_MV_INSUMOS_APLICACIONViewManager> _vT_V_MV_INSUMOS_APLICACIONViewManager;
		public VT_V_MV_INSUMOS_APLICACIONViewManager VT_V_MV_INSUMOS_APLICACIONViewManager {get => _vT_V_MV_INSUMOS_APLICACIONViewManager.Value;}

		private Lazy<VT_V_TA_CPTEViewManager> _vT_V_TA_CPTEViewManager;
		public VT_V_TA_CPTEViewManager VT_V_TA_CPTEViewManager {get => _vT_V_TA_CPTEViewManager.Value;}

		private Lazy<wsSysMobileArticulosViewManager> _wsSysMobileArticulosViewManager;
		public wsSysMobileArticulosViewManager wsSysMobileArticulosViewManager {get => _wsSysMobileArticulosViewManager.Value;}

		private Lazy<wsSysMobileClientesViewManager> _wsSysMobileClientesViewManager;
		public wsSysMobileClientesViewManager wsSysMobileClientesViewManager {get => _wsSysMobileClientesViewManager.Value;}

		private Lazy<wsSysMobileDepositosViewManager> _wsSysMobileDepositosViewManager;
		public wsSysMobileDepositosViewManager wsSysMobileDepositosViewManager {get => _wsSysMobileDepositosViewManager.Value;}

		private Lazy<wsSysMobileRubrosViewManager> _wsSysMobileRubrosViewManager;
		public wsSysMobileRubrosViewManager wsSysMobileRubrosViewManager {get => _wsSysMobileRubrosViewManager.Value;}

		private Lazy<wsSysMobileStockArticulosDepositosViewManager> _wsSysMobileStockArticulosDepositosViewManager;
		public wsSysMobileStockArticulosDepositosViewManager wsSysMobileStockArticulosDepositosViewManager {get => _wsSysMobileStockArticulosDepositosViewManager.Value;}

		private Lazy<wsSysMobileStockArticulosViewManager> _wsSysMobileStockArticulosViewManager;
		public wsSysMobileStockArticulosViewManager wsSysMobileStockArticulosViewManager {get => _wsSysMobileStockArticulosViewManager.Value;}

		private Lazy<wsSysMobileStockComprometidoArticulosViewManager> _wsSysMobileStockComprometidoArticulosViewManager;
		public wsSysMobileStockComprometidoArticulosViewManager wsSysMobileStockComprometidoArticulosViewManager {get => _wsSysMobileStockComprometidoArticulosViewManager.Value;}

		private Lazy<wsSysMobileTotalRegistrosTablasViewManager> _wsSysMobileTotalRegistrosTablasViewManager;
		public wsSysMobileTotalRegistrosTablasViewManager wsSysMobileTotalRegistrosTablasViewManager {get => _wsSysMobileTotalRegistrosTablasViewManager.Value;}

		private Lazy<wsSysMobileVendedoresViewManager> _wsSysMobileVendedoresViewManager;
		public wsSysMobileVendedoresViewManager wsSysMobileVendedoresViewManager {get => _wsSysMobileVendedoresViewManager.Value;}


		private DataManager()
		{
		
		}

		public void InitDataObjects()
		{
			//Repositories
			_aUX_ANEXOARepository  = new Lazy<AUX_ANEXOARepository>(()=>new AUX_ANEXOARepository(ConnectionString,DatabaseEngine));
			_aUX_BALANCEGRALRepository  = new Lazy<AUX_BALANCEGRALRepository>(()=>new AUX_BALANCEGRALRepository(ConnectionString,DatabaseEngine));
			_aUX_EST_PRODRepository  = new Lazy<AUX_EST_PRODRepository>(()=>new AUX_EST_PRODRepository(ConnectionString,DatabaseEngine));
			_aUX_EstadisticaCtaRepository  = new Lazy<AUX_EstadisticaCtaRepository>(()=>new AUX_EstadisticaCtaRepository(ConnectionString,DatabaseEngine));
			_aUX_MAYORESRepository  = new Lazy<AUX_MAYORESRepository>(()=>new AUX_MAYORESRepository(ConnectionString,DatabaseEngine));
			_aux_MV_CpteQRRepository  = new Lazy<Aux_MV_CpteQRRepository>(()=>new Aux_MV_CpteQRRepository(ConnectionString,DatabaseEngine));
			_aux_MV_CpteRepository  = new Lazy<Aux_MV_CpteRepository>(()=>new Aux_MV_CpteRepository(ConnectionString,DatabaseEngine));
			_aUX_SALDOSMENSUALESRepository  = new Lazy<AUX_SALDOSMENSUALESRepository>(()=>new AUX_SALDOSMENSUALESRepository(ConnectionString,DatabaseEngine));
			_aUX_SUBDIARIOSRepository  = new Lazy<AUX_SUBDIARIOSRepository>(()=>new AUX_SUBDIARIOSRepository(ConnectionString,DatabaseEngine));
			_aUX_TMPRepository  = new Lazy<AUX_TMPRepository>(()=>new AUX_TMPRepository(ConnectionString,DatabaseEngine));
			_aUX_TOTALES_DETRepository  = new Lazy<AUX_TOTALES_DETRepository>(()=>new AUX_TOTALES_DETRepository(ConnectionString,DatabaseEngine));
			_aux_totalesRepository  = new Lazy<Aux_totalesRepository>(()=>new Aux_totalesRepository(ConnectionString,DatabaseEngine));
			_c_MV_CPTE_OBSERVRepository  = new Lazy<C_MV_CPTE_OBSERVRepository>(()=>new C_MV_CPTE_OBSERVRepository(ConnectionString,DatabaseEngine));
			_c_MV_CPTE_PERCEPCIONESRepository  = new Lazy<C_MV_CPTE_PERCEPCIONESRepository>(()=>new C_MV_CPTE_PERCEPCIONESRepository(ConnectionString,DatabaseEngine));
			_c_MV_CpteInsumosRepository  = new Lazy<C_MV_CpteInsumosRepository>(()=>new C_MV_CpteInsumosRepository(ConnectionString,DatabaseEngine));
			_c_MV_CpteRepository  = new Lazy<C_MV_CpteRepository>(()=>new C_MV_CpteRepository(ConnectionString,DatabaseEngine));
			_c_MV_CpteTareasRepository  = new Lazy<C_MV_CpteTareasRepository>(()=>new C_MV_CpteTareasRepository(ConnectionString,DatabaseEngine));
			_c_Proveedores_CCompraRepository  = new Lazy<C_Proveedores_CCompraRepository>(()=>new C_Proveedores_CCompraRepository(ConnectionString,DatabaseEngine));
			_cONTROL_ACCESORepository  = new Lazy<CONTROL_ACCESORepository>(()=>new CONTROL_ACCESORepository(ConnectionString,DatabaseEngine));
			_control_MV_CalculoRepository  = new Lazy<Control_MV_CalculoRepository>(()=>new Control_MV_CalculoRepository(ConnectionString,DatabaseEngine));
			_cRM_MV_EVENTOSRepository  = new Lazy<CRM_MV_EVENTOSRepository>(()=>new CRM_MV_EVENTOSRepository(ConnectionString,DatabaseEngine));
			_cRM_TA_EVENTOSRepository  = new Lazy<CRM_TA_EVENTOSRepository>(()=>new CRM_TA_EVENTOSRepository(ConnectionString,DatabaseEngine));
			_dtpropertiesRepository  = new Lazy<dtpropertiesRepository>(()=>new dtpropertiesRepository(ConnectionString,DatabaseEngine));
			_eM_MV_PESADAS_TRIGORepository  = new Lazy<EM_MV_PESADAS_TRIGORepository>(()=>new EM_MV_PESADAS_TRIGORepository(ConnectionString,DatabaseEngine));
			_eQ_COND_INTERFACESRepository  = new Lazy<EQ_COND_INTERFACESRepository>(()=>new EQ_COND_INTERFACESRepository(ConnectionString,DatabaseEngine));
			_eQ_CONDIVA_IMPORTACIONRepository  = new Lazy<EQ_CONDIVA_IMPORTACIONRepository>(()=>new EQ_CONDIVA_IMPORTACIONRepository(ConnectionString,DatabaseEngine));
			_eQ_CTA_INTERFACERepository  = new Lazy<EQ_CTA_INTERFACERepository>(()=>new EQ_CTA_INTERFACERepository(ConnectionString,DatabaseEngine));
			_eQ_TC_INTERFACERepository  = new Lazy<EQ_TC_INTERFACERepository>(()=>new EQ_TC_INTERFACERepository(ConnectionString,DatabaseEngine));
			_gM_V_MV_PLANILLA_CABRepository  = new Lazy<GM_V_MV_PLANILLA_CABRepository>(()=>new GM_V_MV_PLANILLA_CABRepository(ConnectionString,DatabaseEngine));
			_gM_V_MV_PLANILLA_DETALLERepository  = new Lazy<GM_V_MV_PLANILLA_DETALLERepository>(()=>new GM_V_MV_PLANILLA_DETALLERepository(ConnectionString,DatabaseEngine));
			_l_MA_LicenciasCategoriasRepository  = new Lazy<L_MA_LicenciasCategoriasRepository>(()=>new L_MA_LicenciasCategoriasRepository(ConnectionString,DatabaseEngine));
			_l_MA_LICENCIASCtrolMedicoRepository  = new Lazy<L_MA_LICENCIASCtrolMedicoRepository>(()=>new L_MA_LICENCIASCtrolMedicoRepository(ConnectionString,DatabaseEngine));
			_l_MA_LICENCIASDOCUMENTACIONRepository  = new Lazy<L_MA_LICENCIASDOCUMENTACIONRepository>(()=>new L_MA_LICENCIASDOCUMENTACIONRepository(ConnectionString,DatabaseEngine));
			_l_MA_LICENCIASEXAMENESRepository  = new Lazy<L_MA_LICENCIASEXAMENESRepository>(()=>new L_MA_LICENCIASEXAMENESRepository(ConnectionString,DatabaseEngine));
			_l_MA_LicenciasRepository  = new Lazy<L_MA_LicenciasRepository>(()=>new L_MA_LicenciasRepository(ConnectionString,DatabaseEngine));
			_l_MV_LicenciasRepository  = new Lazy<L_MV_LicenciasRepository>(()=>new L_MV_LicenciasRepository(ConnectionString,DatabaseEngine));
			_l_MV_RuitRepository  = new Lazy<L_MV_RuitRepository>(()=>new L_MV_RuitRepository(ConnectionString,DatabaseEngine));
			_l_TA_CategoriasRepository  = new Lazy<L_TA_CategoriasRepository>(()=>new L_TA_CategoriasRepository(ConnectionString,DatabaseEngine));
			_l_TA_ClaseLicenciaRepository  = new Lazy<L_TA_ClaseLicenciaRepository>(()=>new L_TA_ClaseLicenciaRepository(ConnectionString,DatabaseEngine));
			_l_TA_ControlMedicoRepository  = new Lazy<L_TA_ControlMedicoRepository>(()=>new L_TA_ControlMedicoRepository(ConnectionString,DatabaseEngine));
			_l_TA_DocumentacionRepository  = new Lazy<L_TA_DocumentacionRepository>(()=>new L_TA_DocumentacionRepository(ConnectionString,DatabaseEngine));
			_l_TA_ExamenesRepository  = new Lazy<L_TA_ExamenesRepository>(()=>new L_TA_ExamenesRepository(ConnectionString,DatabaseEngine));
			_l_TA_LocalidadesRepository  = new Lazy<L_TA_LocalidadesRepository>(()=>new L_TA_LocalidadesRepository(ConnectionString,DatabaseEngine));
			_l_TA_PartidosRepository  = new Lazy<L_TA_PartidosRepository>(()=>new L_TA_PartidosRepository(ConnectionString,DatabaseEngine));
			_l_TA_TipoDocRepository  = new Lazy<L_TA_TipoDocRepository>(()=>new L_TA_TipoDocRepository(ConnectionString,DatabaseEngine));
			_logDbRepository  = new Lazy<LogDbRepository>(()=>new LogDbRepository(ConnectionString,DatabaseEngine));
			_mA_ARBOL_OPERATIVORepository  = new Lazy<MA_ARBOL_OPERATIVORepository>(()=>new MA_ARBOL_OPERATIVORepository(ConnectionString,DatabaseEngine));
			_mA_BIENES_NOVEDADESRepository  = new Lazy<MA_BIENES_NOVEDADESRepository>(()=>new MA_BIENES_NOVEDADESRepository(ConnectionString,DatabaseEngine));
			_mA_BIENESRepository  = new Lazy<MA_BIENESRepository>(()=>new MA_BIENESRepository(ConnectionString,DatabaseEngine));
			_mA_CalendarioRepository  = new Lazy<MA_CalendarioRepository>(()=>new MA_CalendarioRepository(ConnectionString,DatabaseEngine));
			_mA_CASH_CONTROLRepository  = new Lazy<MA_CASH_CONTROLRepository>(()=>new MA_CASH_CONTROLRepository(ConnectionString,DatabaseEngine));
			_mA_CASH_CTAS_PRINCIPALESRepository  = new Lazy<MA_CASH_CTAS_PRINCIPALESRepository>(()=>new MA_CASH_CTAS_PRINCIPALESRepository(ConnectionString,DatabaseEngine));
			_mA_CASH_DETALLERepository  = new Lazy<MA_CASH_DETALLERepository>(()=>new MA_CASH_DETALLERepository(ConnectionString,DatabaseEngine));
			_mA_CASH_FLOWRepository  = new Lazy<MA_CASH_FLOWRepository>(()=>new MA_CASH_FLOWRepository(ConnectionString,DatabaseEngine));
			_mA_CASH_GRUPORepository  = new Lazy<MA_CASH_GRUPORepository>(()=>new MA_CASH_GRUPORepository(ConnectionString,DatabaseEngine));
			_mA_CASH_PROYECTADORepository  = new Lazy<MA_CASH_PROYECTADORepository>(()=>new MA_CASH_PROYECTADORepository(ConnectionString,DatabaseEngine));
			_mA_CASHPFE_DETALLERepository  = new Lazy<MA_CASHPFE_DETALLERepository>(()=>new MA_CASHPFE_DETALLERepository(ConnectionString,DatabaseEngine));
			_mA_CASHPFE_GRUPORepository  = new Lazy<MA_CASHPFE_GRUPORepository>(()=>new MA_CASHPFE_GRUPORepository(ConnectionString,DatabaseEngine));
			_mA_CASHPFE_PROYECTADORepository  = new Lazy<MA_CASHPFE_PROYECTADORepository>(()=>new MA_CASHPFE_PROYECTADORepository(ConnectionString,DatabaseEngine));
			_mA_CASHPFERepository  = new Lazy<MA_CASHPFERepository>(()=>new MA_CASHPFERepository(ConnectionString,DatabaseEngine));
			_mA_ChoferesRepository  = new Lazy<MA_ChoferesRepository>(()=>new MA_ChoferesRepository(ConnectionString,DatabaseEngine));
			_mA_CONTACTOS_ADICRepository  = new Lazy<MA_CONTACTOS_ADICRepository>(()=>new MA_CONTACTOS_ADICRepository(ConnectionString,DatabaseEngine));
			_mA_CONTACTOSRepository  = new Lazy<MA_CONTACTOSRepository>(()=>new MA_CONTACTOSRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_ALERTASRepository  = new Lazy<MA_CUENTAS_ALERTASRepository>(()=>new MA_CUENTAS_ALERTASRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_ARCHIVOS_RELACIONADOSRepository  = new Lazy<MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository>(()=>new MA_CUENTAS_ARCHIVOS_RELACIONADOSRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_CTAS_BANCARIASRepository  = new Lazy<MA_CUENTAS_CTAS_BANCARIASRepository>(()=>new MA_CUENTAS_CTAS_BANCARIASRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_DATOS_LABORALESRepository  = new Lazy<MA_CUENTAS_DATOS_LABORALESRepository>(()=>new MA_CUENTAS_DATOS_LABORALESRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_DESCUENTO_RUBROSRepository  = new Lazy<MA_CUENTAS_DESCUENTO_RUBROSRepository>(()=>new MA_CUENTAS_DESCUENTO_RUBROSRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_DIRECCIONESRepository  = new Lazy<MA_CUENTAS_DIRECCIONESRepository>(()=>new MA_CUENTAS_DIRECCIONESRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_ENCOMIENDAS_CANTRepository  = new Lazy<MA_CUENTAS_ENCOMIENDAS_CANTRepository>(()=>new MA_CUENTAS_ENCOMIENDAS_CANTRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_ENCOMIENDASRepository  = new Lazy<MA_CUENTAS_ENCOMIENDASRepository>(()=>new MA_CUENTAS_ENCOMIENDASRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_FACTURACION_RECURRENTERepository  = new Lazy<MA_CUENTAS_FACTURACION_RECURRENTERepository>(()=>new MA_CUENTAS_FACTURACION_RECURRENTERepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_FAMILIASRepository  = new Lazy<MA_CUENTAS_FAMILIASRepository>(()=>new MA_CUENTAS_FAMILIASRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_INFO_ADICIONALRepository  = new Lazy<MA_CUENTAS_INFO_ADICIONALRepository>(()=>new MA_CUENTAS_INFO_ADICIONALRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_INFORMESRepository  = new Lazy<MA_CUENTAS_INFORMESRepository>(()=>new MA_CUENTAS_INFORMESRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_RUTEO_VENDEDORRepository  = new Lazy<MA_CUENTAS_RUTEO_VENDEDORRepository>(()=>new MA_CUENTAS_RUTEO_VENDEDORRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_SUCURSALESRepository  = new Lazy<MA_CUENTAS_SUCURSALESRepository>(()=>new MA_CUENTAS_SUCURSALESRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTAS_USUARIOSRepository  = new Lazy<MA_CUENTAS_USUARIOSRepository>(()=>new MA_CUENTAS_USUARIOSRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTASADICRepository  = new Lazy<MA_CUENTASADICRepository>(()=>new MA_CUENTASADICRepository(ConnectionString,DatabaseEngine));
			_mA_CUENTASCCOSTORepository  = new Lazy<MA_CUENTASCCOSTORepository>(()=>new MA_CUENTASCCOSTORepository(ConnectionString,DatabaseEngine));
			_mA_CUENTASRepository  = new Lazy<MA_CUENTASRepository>(()=>new MA_CUENTASRepository(ConnectionString,DatabaseEngine));
			_mA_ESTADISTICACTARepository  = new Lazy<MA_ESTADISTICACTARepository>(()=>new MA_ESTADISTICACTARepository(ConnectionString,DatabaseEngine));
			_mA_INDAJUSTERepository  = new Lazy<MA_INDAJUSTERepository>(()=>new MA_INDAJUSTERepository(ConnectionString,DatabaseEngine));
			_mA_MODELOSRepository  = new Lazy<MA_MODELOSRepository>(()=>new MA_MODELOSRepository(ConnectionString,DatabaseEngine));
			_mA_SUBDIARIOSCOMPROBANTESRepository  = new Lazy<MA_SUBDIARIOSCOMPROBANTESRepository>(()=>new MA_SUBDIARIOSCOMPROBANTESRepository(ConnectionString,DatabaseEngine));
			_mA_SUBDIARIOSRepository  = new Lazy<MA_SUBDIARIOSRepository>(()=>new MA_SUBDIARIOSRepository(ConnectionString,DatabaseEngine));
			_mA_vehiculosRepository  = new Lazy<MA_vehiculosRepository>(()=>new MA_vehiculosRepository(ConnectionString,DatabaseEngine));
			_mV_AgendaRepository  = new Lazy<MV_AgendaRepository>(()=>new MV_AgendaRepository(ConnectionString,DatabaseEngine));
			_mV_APLICACIONRepository  = new Lazy<MV_APLICACIONRepository>(()=>new MV_APLICACIONRepository(ConnectionString,DatabaseEngine));
			_mV_ASIENTOSCCOSTORepository  = new Lazy<MV_ASIENTOSCCOSTORepository>(()=>new MV_ASIENTOSCCOSTORepository(ConnectionString,DatabaseEngine));
			_mV_ASIENTOSRepository  = new Lazy<MV_ASIENTOSRepository>(()=>new MV_ASIENTOSRepository(ConnectionString,DatabaseEngine));
			_mV_BIENES_DETALLERepository  = new Lazy<MV_BIENES_DETALLERepository>(()=>new MV_BIENES_DETALLERepository(ConnectionString,DatabaseEngine));
			_mV_BIENESRepository  = new Lazy<MV_BIENESRepository>(()=>new MV_BIENESRepository(ConnectionString,DatabaseEngine));
			_mV_CALCULO_BIENESRepository  = new Lazy<MV_CALCULO_BIENESRepository>(()=>new MV_CALCULO_BIENESRepository(ConnectionString,DatabaseEngine));
			_mV_CONTROL_AS_RESRepository  = new Lazy<MV_CONTROL_AS_RESRepository>(()=>new MV_CONTROL_AS_RESRepository(ConnectionString,DatabaseEngine));
			_mV_EJERCICIOSRepository  = new Lazy<MV_EJERCICIOSRepository>(()=>new MV_EJERCICIOSRepository(ConnectionString,DatabaseEngine));
			_mV_INVENTARIOSCABRepository  = new Lazy<MV_INVENTARIOSCABRepository>(()=>new MV_INVENTARIOSCABRepository(ConnectionString,DatabaseEngine));
			_mV_INVENTARIOSRepository  = new Lazy<MV_INVENTARIOSRepository>(()=>new MV_INVENTARIOSRepository(ConnectionString,DatabaseEngine));
			_mV_SALDOSRepository  = new Lazy<MV_SALDOSRepository>(()=>new MV_SALDOSRepository(ConnectionString,DatabaseEngine));
			_p_MA_ClientesRepository  = new Lazy<P_MA_ClientesRepository>(()=>new P_MA_ClientesRepository(ConnectionString,DatabaseEngine));
			_p_MA_EmpresasRepository  = new Lazy<P_MA_EmpresasRepository>(()=>new P_MA_EmpresasRepository(ConnectionString,DatabaseEngine));
			_p_MA_FamiliarRepository  = new Lazy<P_MA_FamiliarRepository>(()=>new P_MA_FamiliarRepository(ConnectionString,DatabaseEngine));
			_p_MA_LegajosRepository  = new Lazy<P_MA_LegajosRepository>(()=>new P_MA_LegajosRepository(ConnectionString,DatabaseEngine));
			_p_MA_PostulanteAuxiliarRepository  = new Lazy<P_MA_PostulanteAuxiliarRepository>(()=>new P_MA_PostulanteAuxiliarRepository(ConnectionString,DatabaseEngine));
			_p_MA_Postulantes_ConocimientosRepository  = new Lazy<P_MA_Postulantes_ConocimientosRepository>(()=>new P_MA_Postulantes_ConocimientosRepository(ConnectionString,DatabaseEngine));
			_p_MA_Postulantes_ExperienciaRepository  = new Lazy<P_MA_Postulantes_ExperienciaRepository>(()=>new P_MA_Postulantes_ExperienciaRepository(ConnectionString,DatabaseEngine));
			_p_MA_Postulantes_IdiomasRepository  = new Lazy<P_MA_Postulantes_IdiomasRepository>(()=>new P_MA_Postulantes_IdiomasRepository(ConnectionString,DatabaseEngine));
			_p_MA_Postulantes_ObsRepository  = new Lazy<P_MA_Postulantes_ObsRepository>(()=>new P_MA_Postulantes_ObsRepository(ConnectionString,DatabaseEngine));
			_p_MA_Postulantes_TitulosRepository  = new Lazy<P_MA_Postulantes_TitulosRepository>(()=>new P_MA_Postulantes_TitulosRepository(ConnectionString,DatabaseEngine));
			_p_MA_PostulantesRepository  = new Lazy<P_MA_PostulantesRepository>(()=>new P_MA_PostulantesRepository(ConnectionString,DatabaseEngine));
			_p_MV_BusquedasRepository  = new Lazy<P_MV_BusquedasRepository>(()=>new P_MV_BusquedasRepository(ConnectionString,DatabaseEngine));
			_p_MV_CtrolHorariosRepository  = new Lazy<P_MV_CtrolHorariosRepository>(()=>new P_MV_CtrolHorariosRepository(ConnectionString,DatabaseEngine));
			_p_MV_DeudoresRepository  = new Lazy<P_MV_DeudoresRepository>(()=>new P_MV_DeudoresRepository(ConnectionString,DatabaseEngine));
			_p_MV_EntrevistasRepository  = new Lazy<P_MV_EntrevistasRepository>(()=>new P_MV_EntrevistasRepository(ConnectionString,DatabaseEngine));
			_p_MV_ReferenciasRepository  = new Lazy<P_MV_ReferenciasRepository>(()=>new P_MV_ReferenciasRepository(ConnectionString,DatabaseEngine));
			_p_MV_SeguimientoRepository  = new Lazy<P_MV_SeguimientoRepository>(()=>new P_MV_SeguimientoRepository(ConnectionString,DatabaseEngine));
			_p_MV_SolicitudRRHH_ConocimientosRepository  = new Lazy<P_MV_SolicitudRRHH_ConocimientosRepository>(()=>new P_MV_SolicitudRRHH_ConocimientosRepository(ConnectionString,DatabaseEngine));
			_p_MV_SolicitudRRHH_IdiomasRepository  = new Lazy<P_MV_SolicitudRRHH_IdiomasRepository>(()=>new P_MV_SolicitudRRHH_IdiomasRepository(ConnectionString,DatabaseEngine));
			_p_MV_SolicitudRRHH_TitulosRepository  = new Lazy<P_MV_SolicitudRRHH_TitulosRepository>(()=>new P_MV_SolicitudRRHH_TitulosRepository(ConnectionString,DatabaseEngine));
			_p_MV_SolicitudRRHHRepository  = new Lazy<P_MV_SolicitudRRHHRepository>(()=>new P_MV_SolicitudRRHHRepository(ConnectionString,DatabaseEngine));
			_p_TA_AreasRepository  = new Lazy<P_TA_AreasRepository>(()=>new P_TA_AreasRepository(ConnectionString,DatabaseEngine));
			_p_TA_CategorizacionRepository  = new Lazy<P_TA_CategorizacionRepository>(()=>new P_TA_CategorizacionRepository(ConnectionString,DatabaseEngine));
			_p_TA_CentroMedicoRepository  = new Lazy<P_TA_CentroMedicoRepository>(()=>new P_TA_CentroMedicoRepository(ConnectionString,DatabaseEngine));
			_p_Ta_ConocimientosRepository  = new Lazy<P_Ta_ConocimientosRepository>(()=>new P_Ta_ConocimientosRepository(ConnectionString,DatabaseEngine));
			_p_TA_EstadoBusquedaRepository  = new Lazy<P_TA_EstadoBusquedaRepository>(()=>new P_TA_EstadoBusquedaRepository(ConnectionString,DatabaseEngine));
			_p_TA_EstadoCivilRepository  = new Lazy<P_TA_EstadoCivilRepository>(()=>new P_TA_EstadoCivilRepository(ConnectionString,DatabaseEngine));
			_p_TA_EstadoPostulanteRepository  = new Lazy<P_TA_EstadoPostulanteRepository>(()=>new P_TA_EstadoPostulanteRepository(ConnectionString,DatabaseEngine));
			_p_TA_FormasDePagoRepository  = new Lazy<P_TA_FormasDePagoRepository>(()=>new P_TA_FormasDePagoRepository(ConnectionString,DatabaseEngine));
			_p_TA_FuncionesRepository  = new Lazy<P_TA_FuncionesRepository>(()=>new P_TA_FuncionesRepository(ConnectionString,DatabaseEngine));
			_p_TA_GruposRepository  = new Lazy<P_TA_GruposRepository>(()=>new P_TA_GruposRepository(ConnectionString,DatabaseEngine));
			_p_TA_IdiomasRepository  = new Lazy<P_TA_IdiomasRepository>(()=>new P_TA_IdiomasRepository(ConnectionString,DatabaseEngine));
			_p_TA_MotivoEgresoRepository  = new Lazy<P_TA_MotivoEgresoRepository>(()=>new P_TA_MotivoEgresoRepository(ConnectionString,DatabaseEngine));
			_p_TA_NivelEstudioRepository  = new Lazy<P_TA_NivelEstudioRepository>(()=>new P_TA_NivelEstudioRepository(ConnectionString,DatabaseEngine));
			_p_TA_ObraSocialRepository  = new Lazy<P_TA_ObraSocialRepository>(()=>new P_TA_ObraSocialRepository(ConnectionString,DatabaseEngine));
			_p_TA_ParentescoRepository  = new Lazy<P_TA_ParentescoRepository>(()=>new P_TA_ParentescoRepository(ConnectionString,DatabaseEngine));
			_p_TA_SindicatosRepository  = new Lazy<P_TA_SindicatosRepository>(()=>new P_TA_SindicatosRepository(ConnectionString,DatabaseEngine));
			_p_TA_TipoPuestoRepository  = new Lazy<P_TA_TipoPuestoRepository>(()=>new P_TA_TipoPuestoRepository(ConnectionString,DatabaseEngine));
			_p_TA_TitulosRepository  = new Lazy<P_TA_TitulosRepository>(()=>new P_TA_TitulosRepository(ConnectionString,DatabaseEngine));
			_p_TA_ZonaResidenciaRepository  = new Lazy<P_TA_ZonaResidenciaRepository>(()=>new P_TA_ZonaResidenciaRepository(ConnectionString,DatabaseEngine));
			_pRUEBAESTADISTICARepository  = new Lazy<PRUEBAESTADISTICARepository>(()=>new PRUEBAESTADISTICARepository(ConnectionString,DatabaseEngine));
			_rMA_ESTADOSRepository  = new Lazy<RMA_ESTADOSRepository>(()=>new RMA_ESTADOSRepository(ConnectionString,DatabaseEngine));
			_rMA_MOTIVOSRepository  = new Lazy<RMA_MOTIVOSRepository>(()=>new RMA_MOTIVOSRepository(ConnectionString,DatabaseEngine));
			_rMA_TRAZABILIDAD_ARTICULOSRepository  = new Lazy<RMA_TRAZABILIDAD_ARTICULOSRepository>(()=>new RMA_TRAZABILIDAD_ARTICULOSRepository(ConnectionString,DatabaseEngine));
			_s_TA_EQUIVRepository  = new Lazy<S_TA_EQUIVRepository>(()=>new S_TA_EQUIVRepository(ConnectionString,DatabaseEngine));
			_t_VEHICULOS_NOVEDADESRepository  = new Lazy<T_VEHICULOS_NOVEDADESRepository>(()=>new T_VEHICULOS_NOVEDADESRepository(ConnectionString,DatabaseEngine));
			_tA_AGRUPCUENTAS_DETALLERepository  = new Lazy<TA_AGRUPCUENTAS_DETALLERepository>(()=>new TA_AGRUPCUENTAS_DETALLERepository(ConnectionString,DatabaseEngine));
			_tA_AGRUPCUENTASRepository  = new Lazy<TA_AGRUPCUENTASRepository>(()=>new TA_AGRUPCUENTASRepository(ConnectionString,DatabaseEngine));
			_ta_ArchivoLegalRepository  = new Lazy<Ta_ArchivoLegalRepository>(()=>new Ta_ArchivoLegalRepository(ConnectionString,DatabaseEngine));
			_tA_AUDITORIARepository  = new Lazy<TA_AUDITORIARepository>(()=>new TA_AUDITORIARepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_CCOSTORepository  = new Lazy<TA_BIENES_CCOSTORepository>(()=>new TA_BIENES_CCOSTORepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_CLASESRepository  = new Lazy<TA_BIENES_CLASESRepository>(()=>new TA_BIENES_CLASESRepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_ESTADOSRepository  = new Lazy<TA_BIENES_ESTADOSRepository>(()=>new TA_BIENES_ESTADOSRepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_MARCASRepository  = new Lazy<TA_BIENES_MARCASRepository>(()=>new TA_BIENES_MARCASRepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_MOTIVOSRepository  = new Lazy<TA_BIENES_MOTIVOSRepository>(()=>new TA_BIENES_MOTIVOSRepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_PROPIETARIOSRepository  = new Lazy<TA_BIENES_PROPIETARIOSRepository>(()=>new TA_BIENES_PROPIETARIOSRepository(ConnectionString,DatabaseEngine));
			_tA_BIENES_TIPOSRepository  = new Lazy<TA_BIENES_TIPOSRepository>(()=>new TA_BIENES_TIPOSRepository(ConnectionString,DatabaseEngine));
			_tA_CCOSTORepository  = new Lazy<TA_CCOSTORepository>(()=>new TA_CCOSTORepository(ConnectionString,DatabaseEngine));
			_tA_COMPROBANTESRepository  = new Lazy<TA_COMPROBANTESRepository>(()=>new TA_COMPROBANTESRepository(ConnectionString,DatabaseEngine));
			_tA_CONDIVARepository  = new Lazy<TA_CONDIVARepository>(()=>new TA_CONDIVARepository(ConnectionString,DatabaseEngine));
			_tA_CONFIGURACIONRepository  = new Lazy<TA_CONFIGURACIONRepository>(()=>new TA_CONFIGURACIONRepository(ConnectionString,DatabaseEngine));
			_tA_COTIZACIONRepository  = new Lazy<TA_COTIZACIONRepository>(()=>new TA_COTIZACIONRepository(ConnectionString,DatabaseEngine));
			_tA_CUENTAS_COMPROBANTESRepository  = new Lazy<TA_CUENTAS_COMPROBANTESRepository>(()=>new TA_CUENTAS_COMPROBANTESRepository(ConnectionString,DatabaseEngine));
			_tA_CUENTASIVARepository  = new Lazy<TA_CUENTASIVARepository>(()=>new TA_CUENTASIVARepository(ConnectionString,DatabaseEngine));
			_tA_DistLocalidadesRepository  = new Lazy<TA_DistLocalidadesRepository>(()=>new TA_DistLocalidadesRepository(ConnectionString,DatabaseEngine));
			_tA_ESTADOSRepository  = new Lazy<TA_ESTADOSRepository>(()=>new TA_ESTADOSRepository(ConnectionString,DatabaseEngine));
			_tA_IMPORTACUENTASDETALLERepository  = new Lazy<TA_IMPORTACUENTASDETALLERepository>(()=>new TA_IMPORTACUENTASDETALLERepository(ConnectionString,DatabaseEngine));
			_tA_IMPORTACUENTASRepository  = new Lazy<TA_IMPORTACUENTASRepository>(()=>new TA_IMPORTACUENTASRepository(ConnectionString,DatabaseEngine));
			_tA_INTERFACES_DETALLERepository  = new Lazy<TA_INTERFACES_DETALLERepository>(()=>new TA_INTERFACES_DETALLERepository(ConnectionString,DatabaseEngine));
			_tA_INTERFACESRepository  = new Lazy<TA_INTERFACESRepository>(()=>new TA_INTERFACESRepository(ConnectionString,DatabaseEngine));
			_tA_LOGOSRepository  = new Lazy<TA_LOGOSRepository>(()=>new TA_LOGOSRepository(ConnectionString,DatabaseEngine));
			_tA_MARCASRepository  = new Lazy<TA_MARCASRepository>(()=>new TA_MARCASRepository(ConnectionString,DatabaseEngine));
			_tA_MENURepository  = new Lazy<TA_MENURepository>(()=>new TA_MENURepository(ConnectionString,DatabaseEngine));
			_tA_MONEDASRepository  = new Lazy<TA_MONEDASRepository>(()=>new TA_MONEDASRepository(ConnectionString,DatabaseEngine));
			_ta_NumArchivoLegalRepository  = new Lazy<Ta_NumArchivoLegalRepository>(()=>new Ta_NumArchivoLegalRepository(ConnectionString,DatabaseEngine));
			_tA_PAISESRepository  = new Lazy<TA_PAISESRepository>(()=>new TA_PAISESRepository(ConnectionString,DatabaseEngine));
			_tA_PUBLICACIONESRepository  = new Lazy<TA_PUBLICACIONESRepository>(()=>new TA_PUBLICACIONESRepository(ConnectionString,DatabaseEngine));
			_tA_RANGOS_DATOS_ADICRepository  = new Lazy<TA_RANGOS_DATOS_ADICRepository>(()=>new TA_RANGOS_DATOS_ADICRepository(ConnectionString,DatabaseEngine));
			_tA_REPORTESRepository  = new Lazy<TA_REPORTESRepository>(()=>new TA_REPORTESRepository(ConnectionString,DatabaseEngine));
			_tA_TAREASRepository  = new Lazy<TA_TAREASRepository>(()=>new TA_TAREASRepository(ConnectionString,DatabaseEngine));
			_tA_TERMINALESRepository  = new Lazy<TA_TERMINALESRepository>(()=>new TA_TERMINALESRepository(ConnectionString,DatabaseEngine));
			_tA_TIPODOCUMENTORepository  = new Lazy<TA_TIPODOCUMENTORepository>(()=>new TA_TIPODOCUMENTORepository(ConnectionString,DatabaseEngine));
			_tA_TIPOVEHICULORepository  = new Lazy<TA_TIPOVEHICULORepository>(()=>new TA_TIPOVEHICULORepository(ConnectionString,DatabaseEngine));
			_tA_TITCOPIADORESRepository  = new Lazy<TA_TITCOPIADORESRepository>(()=>new TA_TITCOPIADORESRepository(ConnectionString,DatabaseEngine));
			_tA_USUARIOSRepository  = new Lazy<TA_USUARIOSRepository>(()=>new TA_USUARIOSRepository(ConnectionString,DatabaseEngine));
			_tA_VISTASRepository  = new Lazy<TA_VISTASRepository>(()=>new TA_VISTASRepository(ConnectionString,DatabaseEngine));
			_tESTIGO_EXPORTACIONRepository  = new Lazy<TESTIGO_EXPORTACIONRepository>(()=>new TESTIGO_EXPORTACIONRepository(ConnectionString,DatabaseEngine));
			_tESTIGO_RECEPCIONRepository  = new Lazy<TESTIGO_RECEPCIONRepository>(()=>new TESTIGO_RECEPCIONRepository(ConnectionString,DatabaseEngine));
			_tMP_BusquedaPrecioRepository  = new Lazy<TMP_BusquedaPrecioRepository>(()=>new TMP_BusquedaPrecioRepository(ConnectionString,DatabaseEngine));
			_uTL_TA_VENTANASRepository  = new Lazy<UTL_TA_VENTANASRepository>(()=>new UTL_TA_VENTANASRepository(ConnectionString,DatabaseEngine));
			_v_CRM_MV_CPTERepository  = new Lazy<V_CRM_MV_CPTERepository>(()=>new V_CRM_MV_CPTERepository(ConnectionString,DatabaseEngine));
			_v_CRM_TA_ACCIONESRepository  = new Lazy<V_CRM_TA_ACCIONESRepository>(()=>new V_CRM_TA_ACCIONESRepository(ConnectionString,DatabaseEngine));
			_v_CRM_TA_ESTADOSRepository  = new Lazy<V_CRM_TA_ESTADOSRepository>(()=>new V_CRM_TA_ESTADOSRepository(ConnectionString,DatabaseEngine));
			_v_FIDELIZACION_ARTICULOSRepository  = new Lazy<V_FIDELIZACION_ARTICULOSRepository>(()=>new V_FIDELIZACION_ARTICULOSRepository(ConnectionString,DatabaseEngine));
			_v_FIDELIZACION_MV_PUNTOSRepository  = new Lazy<V_FIDELIZACION_MV_PUNTOSRepository>(()=>new V_FIDELIZACION_MV_PUNTOSRepository(ConnectionString,DatabaseEngine));
			_v_FIDELIZACIONRepository  = new Lazy<V_FIDELIZACIONRepository>(()=>new V_FIDELIZACIONRepository(ConnectionString,DatabaseEngine));
			_v_MA_AERONAVES_COMPONENTESRepository  = new Lazy<V_MA_AERONAVES_COMPONENTESRepository>(()=>new V_MA_AERONAVES_COMPONENTESRepository(ConnectionString,DatabaseEngine));
			_v_MA_AERONAVES_DOCUMENTOSRepository  = new Lazy<V_MA_AERONAVES_DOCUMENTOSRepository>(()=>new V_MA_AERONAVES_DOCUMENTOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_AERONAVESRepository  = new Lazy<V_MA_AERONAVESRepository>(()=>new V_MA_AERONAVESRepository(ConnectionString,DatabaseEngine));
			_v_MA_ARTICULOS_ALERTASRepository  = new Lazy<V_MA_ARTICULOS_ALERTASRepository>(()=>new V_MA_ARTICULOS_ALERTASRepository(ConnectionString,DatabaseEngine));
			_v_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository  = new Lazy<V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository>(()=>new V_MA_ARTICULOS_ATRIBUTOS_PRODUCTIVOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository  = new Lazy<V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository>(()=>new V_MA_ARTICULOS_PROCESOS_PRODUCTIVOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_ARTICULOS_SINONIMOSRepository  = new Lazy<V_MA_ARTICULOS_SINONIMOSRepository>(()=>new V_MA_ARTICULOS_SINONIMOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_ARTICULOSRepository  = new Lazy<V_MA_ARTICULOSRepository>(()=>new V_MA_ARTICULOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_EXPRESOSRepository  = new Lazy<V_MA_EXPRESOSRepository>(()=>new V_MA_EXPRESOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_INSUMOSRepository  = new Lazy<V_MA_INSUMOSRepository>(()=>new V_MA_INSUMOSRepository(ConnectionString,DatabaseEngine));
			_v_MA_POSICRepository  = new Lazy<V_MA_POSICRepository>(()=>new V_MA_POSICRepository(ConnectionString,DatabaseEngine));
			_v_MA_PreciosRepository  = new Lazy<V_MA_PreciosRepository>(()=>new V_MA_PreciosRepository(ConnectionString,DatabaseEngine));
			_v_MV_CPTE_OBSERVRepository  = new Lazy<V_MV_CPTE_OBSERVRepository>(()=>new V_MV_CPTE_OBSERVRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteAccionesRepository  = new Lazy<V_MV_CpteAccionesRepository>(()=>new V_MV_CpteAccionesRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteDocRepository  = new Lazy<V_MV_CpteDocRepository>(()=>new V_MV_CpteDocRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteEnComisionRepository  = new Lazy<V_MV_CpteEnComisionRepository>(()=>new V_MV_CpteEnComisionRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteInsumosRepository  = new Lazy<V_MV_CpteInsumosRepository>(()=>new V_MV_CpteInsumosRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteRepository  = new Lazy<V_MV_CpteRepository>(()=>new V_MV_CpteRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteTareasRepository  = new Lazy<V_MV_CpteTareasRepository>(()=>new V_MV_CpteTareasRepository(ConnectionString,DatabaseEngine));
			_v_MV_CpteTercerosRepository  = new Lazy<V_MV_CpteTercerosRepository>(()=>new V_MV_CpteTercerosRepository(ConnectionString,DatabaseEngine));
			_v_mv_creales_AplicacionRepository  = new Lazy<v_mv_creales_AplicacionRepository>(()=>new v_mv_creales_AplicacionRepository(ConnectionString,DatabaseEngine));
			_v_mv_crealesRepository  = new Lazy<v_mv_crealesRepository>(()=>new v_mv_crealesRepository(ConnectionString,DatabaseEngine));
			_v_MV_CUOTASRepository  = new Lazy<V_MV_CUOTASRepository>(()=>new V_MV_CUOTASRepository(ConnectionString,DatabaseEngine));
			_v_MV_DiariosRepository  = new Lazy<V_MV_DiariosRepository>(()=>new V_MV_DiariosRepository(ConnectionString,DatabaseEngine));
			_v_MV_PreciosHisRepository  = new Lazy<V_MV_PreciosHisRepository>(()=>new V_MV_PreciosHisRepository(ConnectionString,DatabaseEngine));
			_v_MV_SOLICITUD_ARTICULOSRepository  = new Lazy<V_MV_SOLICITUD_ARTICULOSRepository>(()=>new V_MV_SOLICITUD_ARTICULOSRepository(ConnectionString,DatabaseEngine));
			_v_MV_StockRepository  = new Lazy<V_MV_StockRepository>(()=>new V_MV_StockRepository(ConnectionString,DatabaseEngine));
			_v_TA_ALERTAS_STOCKRepository  = new Lazy<V_TA_ALERTAS_STOCKRepository>(()=>new V_TA_ALERTAS_STOCKRepository(ConnectionString,DatabaseEngine));
			_v_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository  = new Lazy<V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository>(()=>new V_TA_ATRIBUTOS_PROCESOS_PRODUCTIVOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_ATRIBUTOS_PROD_ARTICULOSRepository  = new Lazy<V_TA_ATRIBUTOS_PROD_ARTICULOSRepository>(()=>new V_TA_ATRIBUTOS_PROD_ARTICULOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_BancosRepository  = new Lazy<V_TA_BancosRepository>(()=>new V_TA_BancosRepository(ConnectionString,DatabaseEngine));
			_v_TA_BONIFICACIONES_COMPRASRepository  = new Lazy<V_TA_BONIFICACIONES_COMPRASRepository>(()=>new V_TA_BONIFICACIONES_COMPRASRepository(ConnectionString,DatabaseEngine));
			_v_Ta_CajasRepository  = new Lazy<V_Ta_CajasRepository>(()=>new V_Ta_CajasRepository(ConnectionString,DatabaseEngine));
			_v_TA_CATALOGOS_HTM_DETALLERepository  = new Lazy<V_TA_CATALOGOS_HTM_DETALLERepository>(()=>new V_TA_CATALOGOS_HTM_DETALLERepository(ConnectionString,DatabaseEngine));
			_v_TA_CATALOGOS_HTMRepository  = new Lazy<V_TA_CATALOGOS_HTMRepository>(()=>new V_TA_CATALOGOS_HTMRepository(ConnectionString,DatabaseEngine));
			_v_TA_CategoriaRepository  = new Lazy<V_TA_CategoriaRepository>(()=>new V_TA_CategoriaRepository(ConnectionString,DatabaseEngine));
			_v_TA_CLASIFICACION_CREDITICIARepository  = new Lazy<V_TA_CLASIFICACION_CREDITICIARepository>(()=>new V_TA_CLASIFICACION_CREDITICIARepository(ConnectionString,DatabaseEngine));
			_v_TA_COMBOS_DETALLERepository  = new Lazy<V_TA_COMBOS_DETALLERepository>(()=>new V_TA_COMBOS_DETALLERepository(ConnectionString,DatabaseEngine));
			_v_TA_COMBOSRepository  = new Lazy<V_TA_COMBOSRepository>(()=>new V_TA_COMBOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_CONFIG_IMPRESION_CPTESRepository  = new Lazy<V_TA_CONFIG_IMPRESION_CPTESRepository>(()=>new V_TA_CONFIG_IMPRESION_CPTESRepository(ConnectionString,DatabaseEngine));
			_v_TA_Cpra_VtaRepository  = new Lazy<V_TA_Cpra_VtaRepository>(()=>new V_TA_Cpra_VtaRepository(ConnectionString,DatabaseEngine));
			_v_TA_CpteRepository  = new Lazy<V_TA_CpteRepository>(()=>new V_TA_CpteRepository(ConnectionString,DatabaseEngine));
			_v_TA_CTRL_CHEQUERASRepository  = new Lazy<V_TA_CTRL_CHEQUERASRepository>(()=>new V_TA_CTRL_CHEQUERASRepository(ConnectionString,DatabaseEngine));
			_v_TA_CuentasComisionRepository  = new Lazy<V_TA_CuentasComisionRepository>(()=>new V_TA_CuentasComisionRepository(ConnectionString,DatabaseEngine));
			_v_TA_DEPOSITO_MMRepository  = new Lazy<V_TA_DEPOSITO_MMRepository>(()=>new V_TA_DEPOSITO_MMRepository(ConnectionString,DatabaseEngine));
			_v_TA_DEPOSITORepository  = new Lazy<V_TA_DEPOSITORepository>(()=>new V_TA_DEPOSITORepository(ConnectionString,DatabaseEngine));
			_v_TA_DESTINORepository  = new Lazy<V_TA_DESTINORepository>(()=>new V_TA_DESTINORepository(ConnectionString,DatabaseEngine));
			_v_TA_ESCALARETENCIONESRepository  = new Lazy<V_TA_ESCALARETENCIONESRepository>(()=>new V_TA_ESCALARETENCIONESRepository(ConnectionString,DatabaseEngine));
			_v_TA_ESTADO_VISITASRepository  = new Lazy<V_TA_ESTADO_VISITASRepository>(()=>new V_TA_ESTADO_VISITASRepository(ConnectionString,DatabaseEngine));
			_v_TA_FAMILIASRepository  = new Lazy<V_TA_FAMILIASRepository>(()=>new V_TA_FAMILIASRepository(ConnectionString,DatabaseEngine));
			_v_TA_GARANTIASRepository  = new Lazy<V_TA_GARANTIASRepository>(()=>new V_TA_GARANTIASRepository(ConnectionString,DatabaseEngine));
			_v_TA_Input_ComprasRepository  = new Lazy<V_TA_Input_ComprasRepository>(()=>new V_TA_Input_ComprasRepository(ConnectionString,DatabaseEngine));
			_v_TA_Input_VentasRepository  = new Lazy<V_TA_Input_VentasRepository>(()=>new V_TA_Input_VentasRepository(ConnectionString,DatabaseEngine));
			_v_TA_Interfaces_asignacionCamposRepository  = new Lazy<V_TA_Interfaces_asignacionCamposRepository>(()=>new V_TA_Interfaces_asignacionCamposRepository(ConnectionString,DatabaseEngine));
			_v_TA_Interfaces_DetalleRepository  = new Lazy<V_TA_Interfaces_DetalleRepository>(()=>new V_TA_Interfaces_DetalleRepository(ConnectionString,DatabaseEngine));
			_v_TA_Interfaces_EquivalenciaRepository  = new Lazy<V_TA_Interfaces_EquivalenciaRepository>(()=>new V_TA_Interfaces_EquivalenciaRepository(ConnectionString,DatabaseEngine));
			_v_TA_INTERFACES_FILTROSRepository  = new Lazy<V_TA_INTERFACES_FILTROSRepository>(()=>new V_TA_INTERFACES_FILTROSRepository(ConnectionString,DatabaseEngine));
			_v_TA_INTERFACESRepository  = new Lazy<V_TA_INTERFACESRepository>(()=>new V_TA_INTERFACESRepository(ConnectionString,DatabaseEngine));
			_v_TA_MOTIVO_AJUSTESRepository  = new Lazy<V_TA_MOTIVO_AJUSTESRepository>(()=>new V_TA_MOTIVO_AJUSTESRepository(ConnectionString,DatabaseEngine));
			_v_TA_MOTIVO_BAJA_CUENTASRepository  = new Lazy<V_TA_MOTIVO_BAJA_CUENTASRepository>(()=>new V_TA_MOTIVO_BAJA_CUENTASRepository(ConnectionString,DatabaseEngine));
			_v_TA_MotivoCpraRepository  = new Lazy<V_TA_MotivoCpraRepository>(()=>new V_TA_MotivoCpraRepository(ConnectionString,DatabaseEngine));
			_v_TA_MOTIVOS_ANULACIONESRepository  = new Lazy<V_TA_MOTIVOS_ANULACIONESRepository>(()=>new V_TA_MOTIVOS_ANULACIONESRepository(ConnectionString,DatabaseEngine));
			_v_TA_MotivoStockRepository  = new Lazy<V_TA_MotivoStockRepository>(()=>new V_TA_MotivoStockRepository(ConnectionString,DatabaseEngine));
			_v_TA_MotivoVtaRepository  = new Lazy<V_TA_MotivoVtaRepository>(()=>new V_TA_MotivoVtaRepository(ConnectionString,DatabaseEngine));
			_v_TA_OrigenRepository  = new Lazy<V_TA_OrigenRepository>(()=>new V_TA_OrigenRepository(ConnectionString,DatabaseEngine));
			_v_TA_PercepcionRepository  = new Lazy<V_TA_PercepcionRepository>(()=>new V_TA_PercepcionRepository(ConnectionString,DatabaseEngine));
			_v_TA_PLANTILLA_FORMULARIOSRepository  = new Lazy<V_TA_PLANTILLA_FORMULARIOSRepository>(()=>new V_TA_PLANTILLA_FORMULARIOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_PoliticaPreciosRepository  = new Lazy<V_TA_PoliticaPreciosRepository>(()=>new V_TA_PoliticaPreciosRepository(ConnectionString,DatabaseEngine));
			_v_TA_PROCESOS_PRODUCTIVOSRepository  = new Lazy<V_TA_PROCESOS_PRODUCTIVOSRepository>(()=>new V_TA_PROCESOS_PRODUCTIVOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_REPORTES_PERSONALIZADOS_DETALLERepository  = new Lazy<V_TA_REPORTES_PERSONALIZADOS_DETALLERepository>(()=>new V_TA_REPORTES_PERSONALIZADOS_DETALLERepository(ConnectionString,DatabaseEngine));
			_v_TA_REPORTES_PERSONALIZADOSRepository  = new Lazy<V_TA_REPORTES_PERSONALIZADOSRepository>(()=>new V_TA_REPORTES_PERSONALIZADOSRepository(ConnectionString,DatabaseEngine));
			_v_TA_RETENCIONESRepository  = new Lazy<V_TA_RETENCIONESRepository>(()=>new V_TA_RETENCIONESRepository(ConnectionString,DatabaseEngine));
			_v_TA_RubrosRepository  = new Lazy<V_TA_RubrosRepository>(()=>new V_TA_RubrosRepository(ConnectionString,DatabaseEngine));
			_v_TA_SECTORESRepository  = new Lazy<V_TA_SECTORESRepository>(()=>new V_TA_SECTORESRepository(ConnectionString,DatabaseEngine));
			_v_TA_STATUS_NPRepository  = new Lazy<V_TA_STATUS_NPRepository>(()=>new V_TA_STATUS_NPRepository(ConnectionString,DatabaseEngine));
			_v_TA_STATUS_OPRepository  = new Lazy<V_TA_STATUS_OPRepository>(()=>new V_TA_STATUS_OPRepository(ConnectionString,DatabaseEngine));
			_v_TA_SUCURSALESRepository  = new Lazy<V_TA_SUCURSALESRepository>(()=>new V_TA_SUCURSALESRepository(ConnectionString,DatabaseEngine));
			_v_TA_TareasRepository  = new Lazy<V_TA_TareasRepository>(()=>new V_TA_TareasRepository(ConnectionString,DatabaseEngine));
			_v_TA_TecnicosRepository  = new Lazy<V_TA_TecnicosRepository>(()=>new V_TA_TecnicosRepository(ConnectionString,DatabaseEngine));
			_v_TA_TEMPORADASRepository  = new Lazy<V_TA_TEMPORADASRepository>(()=>new V_TA_TEMPORADASRepository(ConnectionString,DatabaseEngine));
			_v_TA_TipoArticuloRepository  = new Lazy<V_TA_TipoArticuloRepository>(()=>new V_TA_TipoArticuloRepository(ConnectionString,DatabaseEngine));
			_v_TA_UnidadRepository  = new Lazy<V_TA_UnidadRepository>(()=>new V_TA_UnidadRepository(ConnectionString,DatabaseEngine));
			_v_TA_VENDEDORES_ALERTASRepository  = new Lazy<V_TA_VENDEDORES_ALERTASRepository>(()=>new V_TA_VENDEDORES_ALERTASRepository(ConnectionString,DatabaseEngine));
			_v_TA_VENDEDORESRepository  = new Lazy<V_TA_VENDEDORESRepository>(()=>new V_TA_VENDEDORESRepository(ConnectionString,DatabaseEngine));
			_v_TA_ZONASRepository  = new Lazy<V_TA_ZONASRepository>(()=>new V_TA_ZONASRepository(ConnectionString,DatabaseEngine));

			//ViewManagers
			_aUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager  = new Lazy<AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager>(()=>new AUX_MV_CPTE_COBRANZAS_COMPROBANTESViewManager(ConnectionString,DatabaseEngine));
			_aUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager  = new Lazy<AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager>(()=>new AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager(ConnectionString,DatabaseEngine));
			_aUX_MV_CPTE_COBRANZASViewManager  = new Lazy<AUX_MV_CPTE_COBRANZASViewManager>(()=>new AUX_MV_CPTE_COBRANZASViewManager(ConnectionString,DatabaseEngine));
			_auxObtieneNetoViewManager  = new Lazy<AuxObtieneNetoViewManager>(()=>new AuxObtieneNetoViewManager(ConnectionString,DatabaseEngine));
			_c_BusquedaPreciosProveedorDtoCpraViewManager  = new Lazy<C_BusquedaPreciosProveedorDtoCpraViewManager>(()=>new C_BusquedaPreciosProveedorDtoCpraViewManager(ConnectionString,DatabaseEngine));
			_c_MV_CPTE_RANKING_CONSUMOViewManager  = new Lazy<C_MV_CPTE_RANKING_CONSUMOViewManager>(()=>new C_MV_CPTE_RANKING_CONSUMOViewManager(ConnectionString,DatabaseEngine));
			_c_RemitosConCobranzasViewManager  = new Lazy<C_RemitosConCobranzasViewManager>(()=>new C_RemitosConCobranzasViewManager(ConnectionString,DatabaseEngine));
			_c_RemitosFacturadosViewManager  = new Lazy<C_RemitosFacturadosViewManager>(()=>new C_RemitosFacturadosViewManager(ConnectionString,DatabaseEngine));
			_c_RemitosPendientesSinProveedorViewManager  = new Lazy<C_RemitosPendientesSinProveedorViewManager>(()=>new C_RemitosPendientesSinProveedorViewManager(ConnectionString,DatabaseEngine));
			_c_RemitosPendientesViewManager  = new Lazy<c_RemitosPendientesViewManager>(()=>new c_RemitosPendientesViewManager(ConnectionString,DatabaseEngine));
			_c_RemitosSinAplicacionViewManager  = new Lazy<C_RemitosSinAplicacionViewManager>(()=>new C_RemitosSinAplicacionViewManager(ConnectionString,DatabaseEngine));
			_chequesFirmadosNoConciliadosViewManager  = new Lazy<ChequesFirmadosNoConciliadosViewManager>(()=>new ChequesFirmadosNoConciliadosViewManager(ConnectionString,DatabaseEngine));
			_cO_AplicacionOCViewManager  = new Lazy<CO_AplicacionOCViewManager>(()=>new CO_AplicacionOCViewManager(ConnectionString,DatabaseEngine));
			_cO_CPTES_CREDITOS_PENDIENTESViewManager  = new Lazy<CO_CPTES_CREDITOS_PENDIENTESViewManager>(()=>new CO_CPTES_CREDITOS_PENDIENTESViewManager(ConnectionString,DatabaseEngine));
			_cO_CPTES_IMPAGOSViewManager  = new Lazy<CO_CPTES_IMPAGOSViewManager>(()=>new CO_CPTES_IMPAGOSViewManager(ConnectionString,DatabaseEngine));
			_cO_FaltantesOCViewManager  = new Lazy<CO_FaltantesOCViewManager>(()=>new CO_FaltantesOCViewManager(ConnectionString,DatabaseEngine));
			_cO_FCCore_PendientesViewManager  = new Lazy<CO_FCCore_PendientesViewManager>(()=>new CO_FCCore_PendientesViewManager(ConnectionString,DatabaseEngine));
			_cO_OCompraPendientes_DetalleViewManager  = new Lazy<CO_OCompraPendientes_DetalleViewManager>(()=>new CO_OCompraPendientes_DetalleViewManager(ConnectionString,DatabaseEngine));
			_cO_OCompraPendientesViewManager  = new Lazy<CO_OCompraPendientesViewManager>(()=>new CO_OCompraPendientesViewManager(ConnectionString,DatabaseEngine));
			_gM_PLANILLASViewManager  = new Lazy<GM_PLANILLASViewManager>(()=>new GM_PLANILLASViewManager(ConnectionString,DatabaseEngine));
			_libroIvaComprasViewManager  = new Lazy<LibroIvaComprasViewManager>(()=>new LibroIvaComprasViewManager(ConnectionString,DatabaseEngine));
			_libroIvaVentasDirecto_ConsignadoViewManager  = new Lazy<LibroIvaVentasDirecto_ConsignadoViewManager>(()=>new LibroIvaVentasDirecto_ConsignadoViewManager(ConnectionString,DatabaseEngine));
			_libroIvaVentasPorPeriodoViewManager  = new Lazy<LibroIvaVentasPorPeriodoViewManager>(()=>new LibroIvaVentasPorPeriodoViewManager(ConnectionString,DatabaseEngine));
			_libroIvaVentasResumenViewManager  = new Lazy<LibroIvaVentasResumenViewManager>(()=>new LibroIvaVentasResumenViewManager(ConnectionString,DatabaseEngine));
			_libroIvaVentasViewManager  = new Lazy<LibroIvaVentasViewManager>(()=>new LibroIvaVentasViewManager(ConnectionString,DatabaseEngine));
			_nW_DOCUMENTADORViewManager  = new Lazy<NW_DOCUMENTADORViewManager>(()=>new NW_DOCUMENTADORViewManager(ConnectionString,DatabaseEngine));
			_p_AUX_LEGAJOSViewManager  = new Lazy<P_AUX_LEGAJOSViewManager>(()=>new P_AUX_LEGAJOSViewManager(ConnectionString,DatabaseEngine));
			_p_ENTREVISTASEVALUACIONESViewManager  = new Lazy<P_ENTREVISTASEVALUACIONESViewManager>(()=>new P_ENTREVISTASEVALUACIONESViewManager(ConnectionString,DatabaseEngine));
			_p_EntrevistasFHViewManager  = new Lazy<P_EntrevistasFHViewManager>(()=>new P_EntrevistasFHViewManager(ConnectionString,DatabaseEngine));
			_p_EntrevistasPendientesFhViewManager  = new Lazy<P_EntrevistasPendientesFhViewManager>(()=>new P_EntrevistasPendientesFhViewManager(ConnectionString,DatabaseEngine));
			_p_EntrevistasPendientesViewManager  = new Lazy<P_EntrevistasPendientesViewManager>(()=>new P_EntrevistasPendientesViewManager(ConnectionString,DatabaseEngine));
			_p_EntrevistasViewManager  = new Lazy<P_EntrevistasViewManager>(()=>new P_EntrevistasViewManager(ConnectionString,DatabaseEngine));
			_p_EvaluacionesPendientesViewManager  = new Lazy<P_EvaluacionesPendientesViewManager>(()=>new P_EvaluacionesPendientesViewManager(ConnectionString,DatabaseEngine));
			_p_EvaluacionesViewManager  = new Lazy<P_EvaluacionesViewManager>(()=>new P_EvaluacionesViewManager(ConnectionString,DatabaseEngine));
			_p_SaldosClientesBusquedasViewManager  = new Lazy<P_SaldosClientesBusquedasViewManager>(()=>new P_SaldosClientesBusquedasViewManager(ConnectionString,DatabaseEngine));
			_p_SaldosClientesViewManager  = new Lazy<P_SaldosClientesViewManager>(()=>new P_SaldosClientesViewManager(ConnectionString,DatabaseEngine));
			_p_Sind_CategoriasViewManager  = new Lazy<P_Sind_CategoriasViewManager>(()=>new P_Sind_CategoriasViewManager(ConnectionString,DatabaseEngine));
			_p_SindCatCargosViewManager  = new Lazy<P_SindCatCargosViewManager>(()=>new P_SindCatCargosViewManager(ConnectionString,DatabaseEngine));
			_p_SindicatosViewManager  = new Lazy<P_SindicatosViewManager>(()=>new P_SindicatosViewManager(ConnectionString,DatabaseEngine));
			_p_SolucitudesAFinalizarViewManager  = new Lazy<P_SolucitudesAFinalizarViewManager>(()=>new P_SolucitudesAFinalizarViewManager(ConnectionString,DatabaseEngine));
			_p_SolucitudesPostulantesViewManager  = new Lazy<P_SolucitudesPostulantesViewManager>(()=>new P_SolucitudesPostulantesViewManager(ConnectionString,DatabaseEngine));
			_p_SolucitudesViewManager  = new Lazy<P_SolucitudesViewManager>(()=>new P_SolucitudesViewManager(ConnectionString,DatabaseEngine));
			_p_TodasLasSolicitudesPostulantesViewManager  = new Lazy<P_TodasLasSolicitudesPostulantesViewManager>(()=>new P_TodasLasSolicitudesPostulantesViewManager(ConnectionString,DatabaseEngine));
			_p_TodasLasSolicitudesPostViewManager  = new Lazy<P_TodasLasSolicitudesPostViewManager>(()=>new P_TodasLasSolicitudesPostViewManager(ConnectionString,DatabaseEngine));
			_p_TodasLasSolicitudesViewManager  = new Lazy<P_TodasLasSolicitudesViewManager>(()=>new P_TodasLasSolicitudesViewManager(ConnectionString,DatabaseEngine));
			_rANKING_CONSUMOViewManager  = new Lazy<RANKING_CONSUMOViewManager>(()=>new RANKING_CONSUMOViewManager(ConnectionString,DatabaseEngine));
			_stk_Ma_ArticulosViewManager  = new Lazy<Stk_Ma_ArticulosViewManager>(()=>new Stk_Ma_ArticulosViewManager(ConnectionString,DatabaseEngine));
			_sTK_PuntoReposicionViewManager  = new Lazy<STK_PuntoReposicionViewManager>(()=>new STK_PuntoReposicionViewManager(ConnectionString,DatabaseEngine));
			_sTK_SALDOS_ART_CON_TROPAViewManager  = new Lazy<STK_SALDOS_ART_CON_TROPAViewManager>(()=>new STK_SALDOS_ART_CON_TROPAViewManager(ConnectionString,DatabaseEngine));
			_sTK_SALDOS_SLViewManager  = new Lazy<STK_SALDOS_SLViewManager>(()=>new STK_SALDOS_SLViewManager(ConnectionString,DatabaseEngine));
			_sTK_SALDOS_UnidadesViewManager  = new Lazy<STK_SALDOS_UnidadesViewManager>(()=>new STK_SALDOS_UnidadesViewManager(ConnectionString,DatabaseEngine));
			_sTK_SERIES_Y_LOTESViewManager  = new Lazy<STK_SERIES_Y_LOTESViewManager>(()=>new STK_SERIES_Y_LOTESViewManager(ConnectionString,DatabaseEngine));
			_sTK_STOCK_EQUIVViewManager  = new Lazy<STK_STOCK_EQUIVViewManager>(()=>new STK_STOCK_EQUIVViewManager(ConnectionString,DatabaseEngine));
			_sW_DOCUMENTADORViewManager  = new Lazy<SW_DOCUMENTADORViewManager>(()=>new SW_DOCUMENTADORViewManager(ConnectionString,DatabaseEngine));
			_sW_TABLAS_CON_CAMPOSViewManager  = new Lazy<SW_TABLAS_CON_CAMPOSViewManager>(()=>new SW_TABLAS_CON_CAMPOSViewManager(ConnectionString,DatabaseEngine));
			_sW_TABLAS_SISTEMAViewManager  = new Lazy<SW_TABLAS_SISTEMAViewManager>(()=>new SW_TABLAS_SISTEMAViewManager(ConnectionString,DatabaseEngine));
			_tmp_cuotasViewManager  = new Lazy<tmp_cuotasViewManager>(()=>new tmp_cuotasViewManager(ConnectionString,DatabaseEngine));
			_v_Aplicacion_OrdenDePagoViewManager  = new Lazy<V_Aplicacion_OrdenDePagoViewManager>(()=>new V_Aplicacion_OrdenDePagoViewManager(ConnectionString,DatabaseEngine));
			_v_AsientosCCostoViewManager  = new Lazy<V_AsientosCCostoViewManager>(()=>new V_AsientosCCostoViewManager(ConnectionString,DatabaseEngine));
			_v_chequesconciliadosViewManager  = new Lazy<v_chequesconciliadosViewManager>(()=>new v_chequesconciliadosViewManager(ConnectionString,DatabaseEngine));
			_v_ChequesEnCarteraViewManager  = new Lazy<V_ChequesEnCarteraViewManager>(()=>new V_ChequesEnCarteraViewManager(ConnectionString,DatabaseEngine));
			_v_ChequesEntregadosViewManager  = new Lazy<V_ChequesEntregadosViewManager>(()=>new V_ChequesEntregadosViewManager(ConnectionString,DatabaseEngine));
			_v_ChequesFirmadosNoConciliadosViewManager  = new Lazy<V_ChequesFirmadosNoConciliadosViewManager>(()=>new V_ChequesFirmadosNoConciliadosViewManager(ConnectionString,DatabaseEngine));
			_v_ChequesFirmadosViewManager  = new Lazy<V_ChequesFirmadosViewManager>(()=>new V_ChequesFirmadosViewManager(ConnectionString,DatabaseEngine));
			_v_ChequesRecibidosViewManager  = new Lazy<V_ChequesRecibidosViewManager>(()=>new V_ChequesRecibidosViewManager(ConnectionString,DatabaseEngine));
			_v_COBRANZASPORUSUARIOViewManager  = new Lazy<V_COBRANZASPORUSUARIOViewManager>(()=>new V_COBRANZASPORUSUARIOViewManager(ConnectionString,DatabaseEngine));
			_v_ConsultaDeRubroTipoProveedorViewManager  = new Lazy<V_ConsultaDeRubroTipoProveedorViewManager>(()=>new V_ConsultaDeRubroTipoProveedorViewManager(ConnectionString,DatabaseEngine));
			_v_ConsultaDeRubroTipoProveerdorArticulosViewManager  = new Lazy<V_ConsultaDeRubroTipoProveerdorArticulosViewManager>(()=>new V_ConsultaDeRubroTipoProveerdorArticulosViewManager(ConnectionString,DatabaseEngine));
			_v_EstadoBancarioViewManager  = new Lazy<V_EstadoBancarioViewManager>(()=>new V_EstadoBancarioViewManager(ConnectionString,DatabaseEngine));
			_v_ImportesAplicadosViewManager  = new Lazy<V_ImportesAplicadosViewManager>(()=>new V_ImportesAplicadosViewManager(ConnectionString,DatabaseEngine));
			_v_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager  = new Lazy<V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager>(()=>new V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOSViewManager(ConnectionString,DatabaseEngine));
			_v_mv_CargosAplicadosViewManager  = new Lazy<v_mv_CargosAplicadosViewManager>(()=>new v_mv_CargosAplicadosViewManager(ConnectionString,DatabaseEngine));
			_v_NP_PENDIENTES_COMPROMETIDOViewManager  = new Lazy<V_NP_PENDIENTES_COMPROMETIDOViewManager>(()=>new V_NP_PENDIENTES_COMPROMETIDOViewManager(ConnectionString,DatabaseEngine));
			_v_NP_PENDIENTES2ViewManager  = new Lazy<V_NP_PENDIENTES2ViewManager>(()=>new V_NP_PENDIENTES2ViewManager(ConnectionString,DatabaseEngine));
			_v_NP_PendientesViewManager  = new Lazy<V_NP_PendientesViewManager>(()=>new V_NP_PendientesViewManager(ConnectionString,DatabaseEngine));
			_v_OF_PENDIENTESViewManager  = new Lazy<V_OF_PENDIENTESViewManager>(()=>new V_OF_PENDIENTESViewManager(ConnectionString,DatabaseEngine));
			_v_OT_PendientesViewManager  = new Lazy<V_OT_PendientesViewManager>(()=>new V_OT_PendientesViewManager(ConnectionString,DatabaseEngine));
			_v_PR_PendientesViewManager  = new Lazy<V_PR_PendientesViewManager>(()=>new V_PR_PendientesViewManager(ConnectionString,DatabaseEngine));
			_v_RemitosConCobranzasViewManager  = new Lazy<V_RemitosConCobranzasViewManager>(()=>new V_RemitosConCobranzasViewManager(ConnectionString,DatabaseEngine));
			_v_RemitosFacturadosViewManager  = new Lazy<V_RemitosFacturadosViewManager>(()=>new V_RemitosFacturadosViewManager(ConnectionString,DatabaseEngine));
			_v_RemitosPendientesViewManager  = new Lazy<V_RemitosPendientesViewManager>(()=>new V_RemitosPendientesViewManager(ConnectionString,DatabaseEngine));
			_v_RemitosSinAplicacionViewManager  = new Lazy<V_RemitosSinAplicacionViewManager>(()=>new V_RemitosSinAplicacionViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager  = new Lazy<VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager>(()=>new VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_CREDITOS_PENDIENTESViewManager  = new Lazy<VE_CPTES_CREDITOS_PENDIENTESViewManager>(()=>new VE_CPTES_CREDITOS_PENDIENTESViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager  = new Lazy<VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager>(()=>new VE_CPTES_IMPAGOS_CON_DETALLE_CPTEViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_IMPAGOSViewManager  = new Lazy<VE_CPTES_IMPAGOSViewManager>(()=>new VE_CPTES_IMPAGOSViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_SALDOS_HABERViewManager  = new Lazy<VE_CPTES_SALDOS_HABERViewManager>(()=>new VE_CPTES_SALDOS_HABERViewManager(ConnectionString,DatabaseEngine));
			_vE_CPTES_SALDOSViewManager  = new Lazy<VE_CPTES_SALDOSViewManager>(()=>new VE_CPTES_SALDOSViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOAPLICACION_HABERViewManager  = new Lazy<VE_SALDOAPLICACION_HABERViewManager>(()=>new VE_SALDOAPLICACION_HABERViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOAPLICACIONViewManager  = new Lazy<VE_SALDOAPLICACIONViewManager>(()=>new VE_SALDOAPLICACIONViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSCTA_DEBEViewManager  = new Lazy<VE_SALDOSCTA_DEBEViewManager>(()=>new VE_SALDOSCTA_DEBEViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSCTA_HABERViewManager  = new Lazy<VE_SALDOSCTA_HABERViewManager>(()=>new VE_SALDOSCTA_HABERViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSCTAViewManager  = new Lazy<VE_SALDOSCTAViewManager>(()=>new VE_SALDOSCTAViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSVDOR_DEBEViewManager  = new Lazy<VE_SALDOSVDOR_DEBEViewManager>(()=>new VE_SALDOSVDOR_DEBEViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSVDOR_HABERViewManager  = new Lazy<VE_SALDOSVDOR_HABERViewManager>(()=>new VE_SALDOSVDOR_HABERViewManager(ConnectionString,DatabaseEngine));
			_vE_SALDOSVDORViewManager  = new Lazy<VE_SALDOSVDORViewManager>(()=>new VE_SALDOSVDORViewManager(ConnectionString,DatabaseEngine));
			_vT_C_MV_INSUMOS_APLICACIONViewManager  = new Lazy<VT_C_MV_INSUMOS_APLICACIONViewManager>(()=>new VT_C_MV_INSUMOS_APLICACIONViewManager(ConnectionString,DatabaseEngine));
			_vt_ClientesViewManager  = new Lazy<Vt_ClientesViewManager>(()=>new Vt_ClientesViewManager(ConnectionString,DatabaseEngine));
			_vT_CO_CPTE_DiferidoViewManager  = new Lazy<VT_CO_CPTE_DiferidoViewManager>(()=>new VT_CO_CPTE_DiferidoViewManager(ConnectionString,DatabaseEngine));
			_vT_COBRANZASViewManager  = new Lazy<VT_COBRANZASViewManager>(()=>new VT_COBRANZASViewManager(ConnectionString,DatabaseEngine));
			_vT_CPTE_DiferidoViewManager  = new Lazy<VT_CPTE_DiferidoViewManager>(()=>new VT_CPTE_DiferidoViewManager(ConnectionString,DatabaseEngine));
			_vT_DEPOSITO_MM_STOCKViewManager  = new Lazy<VT_DEPOSITO_MM_STOCKViewManager>(()=>new VT_DEPOSITO_MM_STOCKViewManager(ConnectionString,DatabaseEngine));
			_vT_DEPOSITO_MMViewManager  = new Lazy<VT_DEPOSITO_MMViewManager>(()=>new VT_DEPOSITO_MMViewManager(ConnectionString,DatabaseEngine));
			_vT_ESTADISTICA_CLIENTES_COBRANZASViewManager  = new Lazy<VT_ESTADISTICA_CLIENTES_COBRANZASViewManager>(()=>new VT_ESTADISTICA_CLIENTES_COBRANZASViewManager(ConnectionString,DatabaseEngine));
			_vT_ESTADISTICA_CLIENTES_ENTREGASViewManager  = new Lazy<VT_ESTADISTICA_CLIENTES_ENTREGASViewManager>(()=>new VT_ESTADISTICA_CLIENTES_ENTREGASViewManager(ConnectionString,DatabaseEngine));
			_vT_ESTADISTICA_CLIENTESViewManager  = new Lazy<VT_ESTADISTICA_CLIENTESViewManager>(()=>new VT_ESTADISTICA_CLIENTESViewManager(ConnectionString,DatabaseEngine));
			_vT_MA_PRECIOS_ARTICULOSViewManager  = new Lazy<VT_MA_PRECIOS_ARTICULOSViewManager>(()=>new VT_MA_PRECIOS_ARTICULOSViewManager(ConnectionString,DatabaseEngine));
			_vT_MA_PRECIOSViewManager  = new Lazy<VT_MA_PRECIOSViewManager>(()=>new VT_MA_PRECIOSViewManager(ConnectionString,DatabaseEngine));
			_vT_MAX_NRO_CPTE_ASIENTOSViewManager  = new Lazy<VT_MAX_NRO_CPTE_ASIENTOSViewManager>(()=>new VT_MAX_NRO_CPTE_ASIENTOSViewManager(ConnectionString,DatabaseEngine));
			_vT_MV_APLICACIONViewManager  = new Lazy<VT_MV_APLICACIONViewManager>(()=>new VT_MV_APLICACIONViewManager(ConnectionString,DatabaseEngine));
			_vT_MV_CUOTAS_IMPAGASViewManager  = new Lazy<VT_MV_CUOTAS_IMPAGASViewManager>(()=>new VT_MV_CUOTAS_IMPAGASViewManager(ConnectionString,DatabaseEngine));
			_vT_MV_CUOTAS_PAGASViewManager  = new Lazy<VT_MV_CUOTAS_PAGASViewManager>(()=>new VT_MV_CUOTAS_PAGASViewManager(ConnectionString,DatabaseEngine));
			_vT_MV_Diarios_DescripViewManager  = new Lazy<VT_MV_Diarios_DescripViewManager>(()=>new VT_MV_Diarios_DescripViewManager(ConnectionString,DatabaseEngine));
			_vT_PLANILLASMovilesViewManager  = new Lazy<VT_PLANILLASMovilesViewManager>(()=>new VT_PLANILLASMovilesViewManager(ConnectionString,DatabaseEngine));
			_vt_ProveedoresViewManager  = new Lazy<Vt_ProveedoresViewManager>(()=>new Vt_ProveedoresViewManager(ConnectionString,DatabaseEngine));
			_vT_RankingConsumo_ClienteViewManager  = new Lazy<VT_RankingConsumo_ClienteViewManager>(()=>new VT_RankingConsumo_ClienteViewManager(ConnectionString,DatabaseEngine));
			_vT_RankingConsumoViewManager  = new Lazy<VT_RankingConsumoViewManager>(()=>new VT_RankingConsumoViewManager(ConnectionString,DatabaseEngine));
			_vT_RubroTipoArticulosDescripcionesViewManager  = new Lazy<VT_RubroTipoArticulosDescripcionesViewManager>(()=>new VT_RubroTipoArticulosDescripcionesViewManager(ConnectionString,DatabaseEngine));
			_vT_RubroTipoDescripcionesViewManager  = new Lazy<VT_RubroTipoDescripcionesViewManager>(()=>new VT_RubroTipoDescripcionesViewManager(ConnectionString,DatabaseEngine));
			_vT_TA_PLANTILLAS_FORMULARIOSViewManager  = new Lazy<VT_TA_PLANTILLAS_FORMULARIOSViewManager>(()=>new VT_TA_PLANTILLAS_FORMULARIOSViewManager(ConnectionString,DatabaseEngine));
			_vT_ULTIMOS_PRECIOS_COMPRAViewManager  = new Lazy<VT_ULTIMOS_PRECIOS_COMPRAViewManager>(()=>new VT_ULTIMOS_PRECIOS_COMPRAViewManager(ConnectionString,DatabaseEngine));
			_vT_ULTIMOS_PRECIOS_VENTAViewManager  = new Lazy<VT_ULTIMOS_PRECIOS_VENTAViewManager>(()=>new VT_ULTIMOS_PRECIOS_VENTAViewManager(ConnectionString,DatabaseEngine));
			_vT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager  = new Lazy<VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager>(()=>new VT_V_MV_CPTE_CON_TABLAS_RELACIONADASViewManager(ConnectionString,DatabaseEngine));
			_vT_V_MV_INSUMOS_APLICACIONViewManager  = new Lazy<VT_V_MV_INSUMOS_APLICACIONViewManager>(()=>new VT_V_MV_INSUMOS_APLICACIONViewManager(ConnectionString,DatabaseEngine));
			_vT_V_TA_CPTEViewManager  = new Lazy<VT_V_TA_CPTEViewManager>(()=>new VT_V_TA_CPTEViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileArticulosViewManager  = new Lazy<wsSysMobileArticulosViewManager>(()=>new wsSysMobileArticulosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileClientesViewManager  = new Lazy<wsSysMobileClientesViewManager>(()=>new wsSysMobileClientesViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileDepositosViewManager  = new Lazy<wsSysMobileDepositosViewManager>(()=>new wsSysMobileDepositosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileRubrosViewManager  = new Lazy<wsSysMobileRubrosViewManager>(()=>new wsSysMobileRubrosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileStockArticulosDepositosViewManager  = new Lazy<wsSysMobileStockArticulosDepositosViewManager>(()=>new wsSysMobileStockArticulosDepositosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileStockArticulosViewManager  = new Lazy<wsSysMobileStockArticulosViewManager>(()=>new wsSysMobileStockArticulosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileStockComprometidoArticulosViewManager  = new Lazy<wsSysMobileStockComprometidoArticulosViewManager>(()=>new wsSysMobileStockComprometidoArticulosViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileTotalRegistrosTablasViewManager  = new Lazy<wsSysMobileTotalRegistrosTablasViewManager>(()=>new wsSysMobileTotalRegistrosTablasViewManager(ConnectionString,DatabaseEngine));
			_wsSysMobileVendedoresViewManager  = new Lazy<wsSysMobileVendedoresViewManager>(()=>new wsSysMobileVendedoresViewManager(ConnectionString,DatabaseEngine));
		}

	}
}
