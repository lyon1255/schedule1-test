using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050A RID: 1290
	public class Business : Property
	{
		// Token: 0x0600721C RID: 29212 RVA: 0x001F3228 File Offset: 0x001F1428
		// Note: this type is marked as 'beforefieldinit'.
		static Business()
		{
			Il2CppClassPointerStore<Business>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Business");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business>.NativeClassPtr);
			Business.NativeFieldInfoPtr_Businesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "Businesses");
			Business.NativeFieldInfoPtr_UnownedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "UnownedBusinesses");
			Business.NativeFieldInfoPtr_OwnedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "OwnedBusinesses");
			Business.NativeFieldInfoPtr_LaunderCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderCapacity");
			Business.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderingOperations");
			Business.NativeFieldInfoPtr_onOperationStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationStarted");
			Business.NativeFieldInfoPtr_onOperationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationFinished");
			Business.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "loader");
			Business.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677605);
			Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677606);
			Business.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677607);
			Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677608);
			Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677609);
			Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677610);
			Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677611);
			Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677612);
			Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677613);
			Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677614);
			Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677615);
			Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677616);
			Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677617);
			Business.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677618);
			Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677619);
			Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677620);
			Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677621);
			Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677622);
			Business.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677623);
			Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677625);
			Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677626);
			Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677627);
			Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677628);
			Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677629);
			Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677630);
			Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677631);
			Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677632);
			Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677633);
			Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677634);
			Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677635);
			Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100677636);
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600721D RID: 29213 RVA: 0x001F358C File Offset: 0x001F178C
		public unsafe float currentLaunderTotal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 223724, RefRangeEnd = 223735, XrefRangeStart = 223706, XrefRangeEnd = 223724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600721E RID: 29214 RVA: 0x001F35C8 File Offset: 0x001F17C8
		public unsafe float appliedLaunderLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223736, RefRangeEnd = 223737, XrefRangeStart = 223735, XrefRangeEnd = 223736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600721F RID: 29215 RVA: 0x001F3604 File Offset: 0x001F1804
		public new unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223737, XrefRangeEnd = 223739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06007220 RID: 29216 RVA: 0x001F363C File Offset: 0x001F183C
		public new unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x001F367C File Offset: 0x001F187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223739, XrefRangeEnd = 223740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x001F36B8 File Offset: 0x001F18B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223740, XrefRangeEnd = 223775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x001F36F4 File Offset: 0x001F18F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223775, XrefRangeEnd = 223790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x001F3730 File Offset: 0x001F1930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223790, XrefRangeEnd = 223796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x001F3780 File Offset: 0x001F1980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223796, XrefRangeEnd = 223805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x001F37D0 File Offset: 0x001F19D0
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x001F380C File Offset: 0x001F1A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223805, XrefRangeEnd = 223817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinsPass(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x001F3858 File Offset: 0x001F1A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223817, XrefRangeEnd = 223841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsPassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsPassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x001F3898 File Offset: 0x001F1A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223841, XrefRangeEnd = 223880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x001F38DC File Offset: 0x001F1ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223880, XrefRangeEnd = 223904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(BusinessData businessData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(businessData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x001F393C File Offset: 0x001F1B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223904, XrefRangeEnd = 223922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x001F3978 File Offset: 0x001F1B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223943, RefRangeEnd = 223944, XrefRangeStart = 223922, XrefRangeEnd = 223943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x001F39C4 File Offset: 0x001F1BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223979, RefRangeEnd = 223982, XrefRangeStart = 223944, XrefRangeEnd = 223979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x001F3A24 File Offset: 0x001F1C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224033, RefRangeEnd = 224034, XrefRangeStart = 223982, XrefRangeEnd = 224033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteOperation(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x001F3A68 File Offset: 0x001F1C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224034, XrefRangeEnd = 224050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Business() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x001F3AA4 File Offset: 0x001F1CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224050, XrefRangeEnd = 224071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x001F3AE0 File Offset: 0x001F1CE0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x001F3B1C File Offset: 0x001F1D1C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x001F3B58 File Offset: 0x001F1D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223943, RefRangeEnd = 223944, XrefRangeStart = 223943, XrefRangeEnd = 223944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x001F3BA4 File Offset: 0x001F1DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224071, XrefRangeEnd = 224072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x001F3BF0 File Offset: 0x001F1DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224072, XrefRangeEnd = 224077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x001F3C54 File Offset: 0x001F1E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224077, XrefRangeEnd = 224089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x001F3CB4 File Offset: 0x001F1EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224105, RefRangeEnd = 224107, XrefRangeStart = 224089, XrefRangeEnd = 224105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x001F3D14 File Offset: 0x001F1F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224107, XrefRangeEnd = 224113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x001F3D64 File Offset: 0x001F1F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224113, XrefRangeEnd = 224134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x001F3DC4 File Offset: 0x001F1FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224134, XrefRangeEnd = 224139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x001F3E14 File Offset: 0x001F2014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224159, RefRangeEnd = 224160, XrefRangeStart = 224139, XrefRangeEnd = 224159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x000364FA File Offset: 0x000346FA
		public Business(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x001F3E50 File Offset: 0x001F2050
		// (set) Token: 0x0600723E RID: 29246 RVA: 0x00036503 File Offset: 0x00034703
		public unsafe static List<Business> Businesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_Businesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_Businesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600723F RID: 29247 RVA: 0x001F3E78 File Offset: 0x001F2078
		// (set) Token: 0x06007240 RID: 29248 RVA: 0x00036515 File Offset: 0x00034715
		public unsafe static List<Business> UnownedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_UnownedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_UnownedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x001F3EA0 File Offset: 0x001F20A0
		// (set) Token: 0x06007242 RID: 29250 RVA: 0x00036527 File Offset: 0x00034727
		public unsafe static List<Business> OwnedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_OwnedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_OwnedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x001F3EC8 File Offset: 0x001F20C8
		// (set) Token: 0x06007244 RID: 29252 RVA: 0x00036539 File Offset: 0x00034739
		public unsafe float LaunderCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity)) = value;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x001F3EF0 File Offset: 0x001F20F0
		// (set) Token: 0x06007246 RID: 29254 RVA: 0x00036554 File Offset: 0x00034754
		public unsafe List<LaunderingOperation> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06007247 RID: 29255 RVA: 0x001F3F20 File Offset: 0x001F2120
		// (set) Token: 0x06007248 RID: 29256 RVA: 0x00036573 File Offset: 0x00034773
		public unsafe static Action<LaunderingOperation> onOperationStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x001F3F48 File Offset: 0x001F2148
		// (set) Token: 0x0600724A RID: 29258 RVA: 0x00036585 File Offset: 0x00034785
		public unsafe static Action<LaunderingOperation> onOperationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x001F3F70 File Offset: 0x001F2170
		// (set) Token: 0x0600724C RID: 29260 RVA: 0x00036597 File Offset: 0x00034797
		public new unsafe BusinessLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x001F3FA0 File Offset: 0x001F21A0
		// (set) Token: 0x0600724E RID: 29262 RVA: 0x000365B6 File Offset: 0x000347B6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x001F3FC8 File Offset: 0x001F21C8
		// (set) Token: 0x06007250 RID: 29264 RVA: 0x000365D1 File Offset: 0x000347D1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004DDC RID: 19932
		private static readonly IntPtr NativeFieldInfoPtr_Businesses;

		// Token: 0x04004DDD RID: 19933
		private static readonly IntPtr NativeFieldInfoPtr_UnownedBusinesses;

		// Token: 0x04004DDE RID: 19934
		private static readonly IntPtr NativeFieldInfoPtr_OwnedBusinesses;

		// Token: 0x04004DDF RID: 19935
		private static readonly IntPtr NativeFieldInfoPtr_LaunderCapacity;

		// Token: 0x04004DE0 RID: 19936
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04004DE1 RID: 19937
		private static readonly IntPtr NativeFieldInfoPtr_onOperationStarted;

		// Token: 0x04004DE2 RID: 19938
		private static readonly IntPtr NativeFieldInfoPtr_onOperationFinished;

		// Token: 0x04004DE3 RID: 19939
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004DE4 RID: 19940
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004DE5 RID: 19941
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004DE6 RID: 19942
		private static readonly IntPtr NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0;

		// Token: 0x04004DE7 RID: 19943
		private static readonly IntPtr NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0;

		// Token: 0x04004DE8 RID: 19944
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004DE9 RID: 19945
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004DEA RID: 19946
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004DEB RID: 19947
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04004DEC RID: 19948
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04004DED RID: 19949
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0;

		// Token: 0x04004DEE RID: 19950
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004DEF RID: 19951
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04004DF0 RID: 19952
		private static readonly IntPtr NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004DF1 RID: 19953
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x04004DF2 RID: 19954
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04004DF3 RID: 19955
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_BusinessData_String_0;

		// Token: 0x04004DF4 RID: 19956
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1;

		// Token: 0x04004DF5 RID: 19957
		private static readonly IntPtr NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0;

		// Token: 0x04004DF6 RID: 19958
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004DF7 RID: 19959
		private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0;

		// Token: 0x04004DF8 RID: 19960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DF9 RID: 19961
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004DFA RID: 19962
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004DFB RID: 19963
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004DFC RID: 19964
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0;

		// Token: 0x04004DFD RID: 19965
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0;

		// Token: 0x04004DFE RID: 19966
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004DFF RID: 19967
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E00 RID: 19968
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E01 RID: 19969
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E02 RID: 19970
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04004E03 RID: 19971
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E04 RID: 19972
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A82 RID: 2690
		[ObfuscatedName("ScheduleOne.Property.Business+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D1F9 RID: 53753 RVA: 0x00323FF8 File Offset: 0x003221F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Business.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Business>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business.__c>.NativeClassPtr);
				Business.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9");
				Business.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9__8_0");
				Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677638);
				Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100677639);
			}

			// Token: 0x0600D1FA RID: 53754 RVA: 0x00324074 File Offset: 0x00322274
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1FB RID: 53755 RVA: 0x003240B0 File Offset: 0x003222B0
			[CallerCount(0)]
			public unsafe float _get_currentLaunderTotal_b__8_0(LaunderingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1FC RID: 53756 RVA: 0x00066434 File Offset: 0x00064634
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412F RID: 16687
			// (get) Token: 0x0600D1FD RID: 53757 RVA: 0x00324100 File Offset: 0x00322300
			// (set) Token: 0x0600D1FE RID: 53758 RVA: 0x0006643D File Offset: 0x0006463D
			public unsafe static Business.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004130 RID: 16688
			// (get) Token: 0x0600D1FF RID: 53759 RVA: 0x00324128 File Offset: 0x00322328
			// (set) Token: 0x0600D200 RID: 53760 RVA: 0x0006644F File Offset: 0x0006464F
			public unsafe static Func<LaunderingOperation, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LaunderingOperation, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DA5 RID: 36261
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DA6 RID: 36262
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008DA7 RID: 36263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DA8 RID: 36264
			private static readonly IntPtr NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0;
		}
	}
}
