using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000408 RID: 1032
	public class Employee : NPC
	{
		// Token: 0x060057A7 RID: 22439 RVA: 0x00198ED0 File Offset: 0x001970D0
		// Note: this type is marked as 'beforefieldinit'.
		static Employee()
		{
			Il2CppClassPointerStore<Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee>.NativeClassPtr);
			Employee.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DEBUG");
			Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AssignedProperty>k__BackingField");
			Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<EmployeeIndex>k__BackingField");
			Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr__Fired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<Fired>k__BackingField");
			Employee.NativeFieldInfoPtr__IsMale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<IsMale>k__BackingField");
			Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AppearanceIndex>k__BackingField");
			Employee.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "Type");
			Employee.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "SigningFee");
			Employee.NativeFieldInfoPtr_DailyWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DailyWage");
			Employee.NativeFieldInfoPtr_WaitOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WaitOutside");
			Employee.NativeFieldInfoPtr_MoveItemBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MoveItemBehaviour");
			Employee.NativeFieldInfoPtr_BedNotAssignedDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "BedNotAssignedDialogue");
			Employee.NativeFieldInfoPtr_NotPaidDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NotPaidDialogue");
			Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssueDialogueTemplate");
			Employee.NativeFieldInfoPtr_FireDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "FireDialogue");
			Employee.NativeFieldInfoPtr_WorkIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssues");
			Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<TimeSinceLastWorked>k__BackingField");
			Employee.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "initialized");
			Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "syncVar___<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674344);
			Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674345);
			Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674346);
			Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674347);
			Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674348);
			Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674349);
			Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674350);
			Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674351);
			Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674352);
			Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674353);
			Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674354);
			Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674355);
			Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674356);
			Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674357);
			Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674358);
			Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674359);
			Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674360);
			Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674361);
			Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674362);
			Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674363);
			Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674364);
			Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674365);
			Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674366);
			Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674367);
			Employee.NativeMethodInfoPtr_SendFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674368);
			Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674369);
			Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674370);
			Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674371);
			Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674372);
			Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674373);
			Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674374);
			Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674375);
			Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674376);
			Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674377);
			Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674378);
			Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674379);
			Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674380);
			Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674381);
			Employee.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674382);
			Employee.NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674383);
			Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674384);
			Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674385);
			Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674386);
			Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674387);
			Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674388);
			Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674389);
			Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674390);
			Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674391);
			Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674392);
			Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674393);
			Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674394);
			Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674395);
			Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674396);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674397);
			Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674398);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674399);
			Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674400);
			Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674401);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674402);
			Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674403);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674404);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674405);
			Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674406);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674407);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674408);
			Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674409);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674410);
			Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674411);
			Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674412);
			Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674413);
			Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674414);
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x00199644 File Offset: 0x00197844
		// (set) Token: 0x060057A9 RID: 22441 RVA: 0x00199684 File Offset: 0x00197884
		public unsafe Property AssignedProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x001996C8 File Offset: 0x001978C8
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x00199704 File Offset: 0x00197904
		public unsafe int EmployeeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x00199744 File Offset: 0x00197944
		// (set) Token: 0x060057AD RID: 22445 RVA: 0x00199780 File Offset: 0x00197980
		public unsafe bool PaidForToday
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 184982, RefRangeEnd = 184983, XrefRangeStart = 184982, XrefRangeEnd = 184982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 184990, RefRangeEnd = 184993, XrefRangeStart = 184983, XrefRangeEnd = 184990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x001997C0 File Offset: 0x001979C0
		// (set) Token: 0x060057AF RID: 22447 RVA: 0x001997FC File Offset: 0x001979FC
		public unsafe bool Fired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x0019983C File Offset: 0x00197A3C
		public unsafe bool IsWaitingOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060057B1 RID: 22449 RVA: 0x00199878 File Offset: 0x00197A78
		// (set) Token: 0x060057B2 RID: 22450 RVA: 0x001998B4 File Offset: 0x00197AB4
		public unsafe bool IsMale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060057B3 RID: 22451 RVA: 0x001998F4 File Offset: 0x00197AF4
		// (set) Token: 0x060057B4 RID: 22452 RVA: 0x00199930 File Offset: 0x00197B30
		public unsafe int AppearanceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060057B5 RID: 22453 RVA: 0x00199970 File Offset: 0x00197B70
		public unsafe EEmployeeType EmployeeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x001999AC File Offset: 0x00197BAC
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x001999E8 File Offset: 0x00197BE8
		public unsafe int TimeSinceLastWorked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00199A28 File Offset: 0x00197C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185043, RefRangeEnd = 185044, XrefRangeStart = 184993, XrefRangeEnd = 185043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00199A64 File Offset: 0x00197C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185044, XrefRangeEnd = 185053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00199AA0 File Offset: 0x00197CA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185056, RefRangeEnd = 185060, XrefRangeStart = 185053, XrefRangeEnd = 185056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00199AF0 File Offset: 0x00197CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185060, XrefRangeEnd = 185116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00199BB8 File Offset: 0x00197DB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185123, RefRangeEnd = 185127, XrefRangeStart = 185116, XrefRangeEnd = 185123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00199C08 File Offset: 0x00197E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185127, XrefRangeEnd = 185140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeInfo(string firstName, string lastName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x00199C7C File Offset: 0x00197E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185140, XrefRangeEnd = 185170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00199CD4 File Offset: 0x00197ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185170, XrefRangeEnd = 185190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckDialogueChoice(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00199D24 File Offset: 0x00197F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185190, XrefRangeEnd = 185208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00199D58 File Offset: 0x00197F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185208, XrefRangeEnd = 185226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00199D8C File Offset: 0x00197F8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185242, RefRangeEnd = 185246, XrefRangeStart = 185226, XrefRangeEnd = 185242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00199DC8 File Offset: 0x00197FC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185254, RefRangeEnd = 185258, XrefRangeStart = 185246, XrefRangeEnd = 185254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00199E04 File Offset: 0x00198004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185258, XrefRangeEnd = 185287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00199E40 File Offset: 0x00198040
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185326, RefRangeEnd = 185329, XrefRangeStart = 185287, XrefRangeEnd = 185326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00199E7C File Offset: 0x0019807C
		[CallerCount(0)]
		public unsafe void MarkIsWorking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00199EB0 File Offset: 0x001980B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185331, RefRangeEnd = 185333, XrefRangeStart = 185329, XrefRangeEnd = 185331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitOutside(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref wait;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00199EF0 File Offset: 0x001980F0
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00199F38 File Offset: 0x00198138
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00199F90 File Offset: 0x00198190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185333, XrefRangeEnd = 185337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00199FCC File Offset: 0x001981CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185337, XrefRangeEnd = 185338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd(int sleepTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sleepTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x0019A00C File Offset: 0x0019820C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185339, RefRangeEnd = 185340, XrefRangeStart = 185338, XrefRangeEnd = 185339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x0019A040 File Offset: 0x00198240
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0019A088 File Offset: 0x00198288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185340, XrefRangeEnd = 185349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x0019A0CC File Offset: 0x001982CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185349, XrefRangeEnd = 185355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0019A118 File Offset: 0x00198318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185360, RefRangeEnd = 185362, XrefRangeStart = 185355, XrefRangeEnd = 185360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPayAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0019A154 File Offset: 0x00198354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185362, XrefRangeEnd = 185374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDailyWage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0019A188 File Offset: 0x00198388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185374, XrefRangeEnd = 185408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			notWorkingReason = ((intPtr4 == 0) ? null : new DialogueContainer(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0019A1F4 File Offset: 0x001983F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185408, XrefRangeEnd = 185409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref idle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x0019A240 File Offset: 0x00198440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185409, XrefRangeEnd = 185415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeavePropertyAndDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0019A274 File Offset: 0x00198474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185440, RefRangeEnd = 185442, XrefRangeStart = 185415, XrefRangeEnd = 185440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0019A2D8 File Offset: 0x001984D8
		[CallerCount(0)]
		public unsafe bool ShouldShowNoWorkDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0019A324 File Offset: 0x00198524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185442, XrefRangeEnd = 185443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotWorkingDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x0019A358 File Offset: 0x00198558
		[CallerCount(0)]
		public unsafe bool ShouldShowFireDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x0019A3A4 File Offset: 0x001985A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185451, RefRangeEnd = 185455, XrefRangeStart = 185443, XrefRangeEnd = 185451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x0019A3E0 File Offset: 0x001985E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185504, RefRangeEnd = 185508, XrefRangeStart = 185455, XrefRangeEnd = 185504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x0019A41C File Offset: 0x0019861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185508, XrefRangeEnd = 185509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x0019A458 File Offset: 0x00198658
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x0019A494 File Offset: 0x00198694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185509, XrefRangeEnd = 185535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x0019A550 File Offset: 0x00198750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185569, RefRangeEnd = 185572, XrefRangeStart = 185535, XrefRangeEnd = 185569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x0019A618 File Offset: 0x00198818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185572, XrefRangeEnd = 185582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x0019A668 File Offset: 0x00198868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185582, XrefRangeEnd = 185599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x0019A724 File Offset: 0x00198924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185599, XrefRangeEnd = 185609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0019A774 File Offset: 0x00198974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0019A7A8 File Offset: 0x001989A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x0019A7DC File Offset: 0x001989DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185609, XrefRangeEnd = 185619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0019A840 File Offset: 0x00198A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0019A874 File Offset: 0x00198A74
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x0019A8A8 File Offset: 0x00198AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185619, XrefRangeEnd = 185620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x0019A8F8 File Offset: 0x00198AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185620, XrefRangeEnd = 185633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x0019A95C File Offset: 0x00198B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185648, RefRangeEnd = 185650, XrefRangeStart = 185633, XrefRangeEnd = 185648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x0019A9C0 File Offset: 0x00198BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185650, XrefRangeEnd = 185657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060057EB RID: 22507 RVA: 0x0019AA10 File Offset: 0x00198C10
		// (set) Token: 0x060057EC RID: 22508 RVA: 0x0019AA4C File Offset: 0x00198C4C
		public unsafe bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 184982, RefRangeEnd = 184983, XrefRangeStart = 184982, XrefRangeEnd = 184983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 185665, RefRangeEnd = 185666, XrefRangeStart = 185657, XrefRangeEnd = 185665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x0019AA98 File Offset: 0x00198C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185666, XrefRangeEnd = 185669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0019AB0C File Offset: 0x00198D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00029BCB File Offset: 0x00027DCB
		public Employee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x060057F0 RID: 22512 RVA: 0x0019AB48 File Offset: 0x00198D48
		// (set) Token: 0x060057F1 RID: 22513 RVA: 0x00029BD4 File Offset: 0x00027DD4
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x0019AB70 File Offset: 0x00198D70
		// (set) Token: 0x060057F3 RID: 22515 RVA: 0x00029BEF File Offset: 0x00027DEF
		public unsafe Property _AssignedProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x0019ABA0 File Offset: 0x00198DA0
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x00029C0E File Offset: 0x00027E0E
		public unsafe int _EmployeeIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x0019ABC8 File Offset: 0x00198DC8
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x00029C29 File Offset: 0x00027E29
		public unsafe bool _PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x0019ABF0 File Offset: 0x00198DF0
		// (set) Token: 0x060057F9 RID: 22521 RVA: 0x00029C44 File Offset: 0x00027E44
		public unsafe bool _Fired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x0019AC18 File Offset: 0x00198E18
		// (set) Token: 0x060057FB RID: 22523 RVA: 0x00029C5F File Offset: 0x00027E5F
		public unsafe bool _IsMale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x0019AC40 File Offset: 0x00198E40
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x00029C7A File Offset: 0x00027E7A
		public unsafe int _AppearanceIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x0019AC68 File Offset: 0x00198E68
		// (set) Token: 0x060057FF RID: 22527 RVA: 0x00029C95 File Offset: 0x00027E95
		public unsafe EEmployeeType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x0019AC90 File Offset: 0x00198E90
		// (set) Token: 0x06005801 RID: 22529 RVA: 0x00029CB0 File Offset: 0x00027EB0
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x0019ACB8 File Offset: 0x00198EB8
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x00029CCB File Offset: 0x00027ECB
		public unsafe float DailyWage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage)) = value;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x0019ACE0 File Offset: 0x00198EE0
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x00029CE6 File Offset: 0x00027EE6
		public unsafe IdleBehaviour WaitOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdleBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x0019AD10 File Offset: 0x00198F10
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x00029D05 File Offset: 0x00027F05
		public unsafe MoveItemBehaviour MoveItemBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0019AD40 File Offset: 0x00198F40
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x00029D24 File Offset: 0x00027F24
		public unsafe DialogueContainer BedNotAssignedDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x0019AD70 File Offset: 0x00198F70
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x00029D43 File Offset: 0x00027F43
		public unsafe DialogueContainer NotPaidDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x0019ADA0 File Offset: 0x00198FA0
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x00029D62 File Offset: 0x00027F62
		public unsafe DialogueContainer WorkIssueDialogueTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x0019ADD0 File Offset: 0x00198FD0
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x00029D81 File Offset: 0x00027F81
		public unsafe DialogueContainer FireDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x0019AE00 File Offset: 0x00199000
		// (set) Token: 0x06005811 RID: 22545 RVA: 0x00029DA0 File Offset: 0x00027FA0
		public unsafe List<Employee.NoWorkReason> WorkIssues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee.NoWorkReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x0019AE30 File Offset: 0x00199030
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x00029DBF File Offset: 0x00027FBF
		public unsafe int _TimeSinceLastWorked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x0019AE58 File Offset: 0x00199058
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x00029DDA File Offset: 0x00027FDA
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x0019AE80 File Offset: 0x00199080
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x00029DF5 File Offset: 0x00027FF5
		public unsafe SyncVar<bool> syncVar____PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0019AEB0 File Offset: 0x001990B0
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x00029E14 File Offset: 0x00028014
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0019AED8 File Offset: 0x001990D8
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x00029E2F File Offset: 0x0002802F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeFieldInfoPtr__AssignedProperty_k__BackingField;

		// Token: 0x04003B9F RID: 15263
		private static readonly IntPtr NativeFieldInfoPtr__EmployeeIndex_k__BackingField;

		// Token: 0x04003BA0 RID: 15264
		private static readonly IntPtr NativeFieldInfoPtr__PaidForToday_k__BackingField;

		// Token: 0x04003BA1 RID: 15265
		private static readonly IntPtr NativeFieldInfoPtr__Fired_k__BackingField;

		// Token: 0x04003BA2 RID: 15266
		private static readonly IntPtr NativeFieldInfoPtr__IsMale_k__BackingField;

		// Token: 0x04003BA3 RID: 15267
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceIndex_k__BackingField;

		// Token: 0x04003BA4 RID: 15268
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04003BA5 RID: 15269
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003BA6 RID: 15270
		private static readonly IntPtr NativeFieldInfoPtr_DailyWage;

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_WaitOutside;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemBehaviour;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr_BedNotAssignedDialogue;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr_NotPaidDialogue;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssueDialogueTemplate;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeFieldInfoPtr_FireDialogue;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssues;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeMethodInfoPtr_SendFire_Public_Void_0;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFire_Private_Void_0;

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeMethodInfoPtr_CanWork_Protected_Boolean_0;

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0;

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003BD4 RID: 15316
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0;

		// Token: 0x04003BD5 RID: 15317
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04003BD6 RID: 15318
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0;

		// Token: 0x04003BD7 RID: 15319
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPaid_Public_Void_0;

		// Token: 0x04003BD8 RID: 15320
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04003BD9 RID: 15321
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003BDA RID: 15322
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0;

		// Token: 0x04003BDB RID: 15323
		private static readonly IntPtr NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0;

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0;

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0;

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0;

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003BE2 RID: 15330
		private static readonly IntPtr NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0;

		// Token: 0x04003BE3 RID: 15331
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003BE4 RID: 15332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003BE5 RID: 15333
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003BE6 RID: 15334
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0;

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009CF RID: 2511
		public class NoWorkReason : Object
		{
			// Token: 0x0600CCAF RID: 52399 RVA: 0x00315938 File Offset: 0x00313B38
			// Note: this type is marked as 'beforefieldinit'.
			static NoWorkReason()
			{
				Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NoWorkReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr);
				Employee.NoWorkReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Reason");
				Employee.NoWorkReason.NativeFieldInfoPtr_Fix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Fix");
				Employee.NoWorkReason.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Priority");
				Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, 100674415);
			}

			// Token: 0x0600CCB0 RID: 52400 RVA: 0x003159B4 File Offset: 0x00313BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184979, XrefRangeEnd = 184982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoWorkReason(string reason, string fix, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCB1 RID: 52401 RVA: 0x00063889 File Offset: 0x00061A89
			public NoWorkReason(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x00315A20 File Offset: 0x00313C20
			// (set) Token: 0x0600CCB3 RID: 52403 RVA: 0x00063892 File Offset: 0x00061A92
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FC3 RID: 16323
			// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x00315A48 File Offset: 0x00313C48
			// (set) Token: 0x0600CCB5 RID: 52405 RVA: 0x000638B1 File Offset: 0x00061AB1
			public unsafe string Fix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FC4 RID: 16324
			// (get) Token: 0x0600CCB6 RID: 52406 RVA: 0x00315A70 File Offset: 0x00313C70
			// (set) Token: 0x0600CCB7 RID: 52407 RVA: 0x000638D0 File Offset: 0x00061AD0
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008A63 RID: 35427
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x04008A64 RID: 35428
			private static readonly IntPtr NativeFieldInfoPtr_Fix;

			// Token: 0x04008A65 RID: 35429
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008A66 RID: 35430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
		}
	}
}
