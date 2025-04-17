using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005C9 RID: 1481
	public class LoadingDock : Constructable_GridBased
	{
		// Token: 0x06008214 RID: 33300 RVA: 0x0022A1CC File Offset: 0x002283CC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingDock()
		{
			Il2CppClassPointerStore<LoadingDock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "LoadingDock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr);
			LoadingDock.NativeFieldInfoPtr_vehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "vehicleDetector");
			LoadingDock.NativeFieldInfoPtr_redLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMeshes");
			LoadingDock.NativeFieldInfoPtr_greenLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMeshes");
			LoadingDock.NativeFieldInfoPtr_sideWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "sideWalls");
			LoadingDock.NativeFieldInfoPtr_gateAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "gateAnim");
			LoadingDock.NativeFieldInfoPtr_reservationBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "reservationBlocker");
			LoadingDock.NativeFieldInfoPtr_vehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "vehiclePosition");
			LoadingDock.NativeFieldInfoPtr_redLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMat_On");
			LoadingDock.NativeFieldInfoPtr_redLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "redLightMat_Off");
			LoadingDock.NativeFieldInfoPtr_greenLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMat_On");
			LoadingDock.NativeFieldInfoPtr_greenLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "greenLightMat_Off");
			LoadingDock.NativeFieldInfoPtr_wallsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "wallsOpen");
			LoadingDock.NativeFieldInfoPtr_currentOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "currentOccupant");
			LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<reservant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted");
			LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted");
			LoadingDock.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679572);
			LoadingDock.NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679573);
			LoadingDock.NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679574);
			LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679575);
			LoadingDock.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679576);
			LoadingDock.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679577);
			LoadingDock.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679578);
			LoadingDock.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679579);
			LoadingDock.NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679580);
			LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679581);
			LoadingDock.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679582);
			LoadingDock.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679583);
			LoadingDock.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679584);
			LoadingDock.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100679585);
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x0022A454 File Offset: 0x00228654
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245673, XrefRangeEnd = 245674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x0022A490 File Offset: 0x00228690
		// (set) Token: 0x06008217 RID: 33303 RVA: 0x0022A4D0 File Offset: 0x002286D0
		public unsafe LandVehicle reservant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245674, XrefRangeEnd = 245675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x0022A514 File Offset: 0x00228714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245675, XrefRangeEnd = 245678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x0022A548 File Offset: 0x00228748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245678, XrefRangeEnd = 245689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0022A584 File Offset: 0x00228784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245689, XrefRangeEnd = 245720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x0022A5C0 File Offset: 0x002287C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245720, XrefRangeEnd = 245728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0022A624 File Offset: 0x00228824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245728, XrefRangeEnd = 245736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x0022A670 File Offset: 0x00228870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245736, XrefRangeEnd = 245774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReservant(LandVehicle _res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x0022A6B4 File Offset: 0x002288B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingDock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x0022A6F0 File Offset: 0x002288F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245774, XrefRangeEnd = 245775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x0022A72C File Offset: 0x0022892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245775, XrefRangeEnd = 245776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x0022A768 File Offset: 0x00228968
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0022A7A4 File Offset: 0x002289A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x0003DD7D File Offset: 0x0003BF7D
		public LoadingDock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x0022A7E0 File Offset: 0x002289E0
		// (set) Token: 0x06008225 RID: 33317 RVA: 0x0003DD86 File Offset: 0x0003BF86
		public unsafe VehicleDetector vehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06008226 RID: 33318 RVA: 0x0022A810 File Offset: 0x00228A10
		// (set) Token: 0x06008227 RID: 33319 RVA: 0x0003DDA5 File Offset: 0x0003BFA5
		public unsafe Il2CppReferenceArray<MeshRenderer> redLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x0022A840 File Offset: 0x00228A40
		// (set) Token: 0x06008229 RID: 33321 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
		public unsafe Il2CppReferenceArray<MeshRenderer> greenLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x0022A870 File Offset: 0x00228A70
		// (set) Token: 0x0600822B RID: 33323 RVA: 0x0003DDE3 File Offset: 0x0003BFE3
		public unsafe Il2CppReferenceArray<Transform> sideWalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_sideWalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_sideWalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600822C RID: 33324 RVA: 0x0022A8A0 File Offset: 0x00228AA0
		// (set) Token: 0x0600822D RID: 33325 RVA: 0x0003DE02 File Offset: 0x0003C002
		public unsafe Animation gateAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_gateAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_gateAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600822E RID: 33326 RVA: 0x0022A8D0 File Offset: 0x00228AD0
		// (set) Token: 0x0600822F RID: 33327 RVA: 0x0003DE21 File Offset: 0x0003C021
		public unsafe Collider reservationBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_reservationBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_reservationBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x0022A900 File Offset: 0x00228B00
		// (set) Token: 0x06008231 RID: 33329 RVA: 0x0003DE40 File Offset: 0x0003C040
		public unsafe Transform vehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_vehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x0022A930 File Offset: 0x00228B30
		// (set) Token: 0x06008233 RID: 33331 RVA: 0x0003DE5F File Offset: 0x0003C05F
		public unsafe Material redLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06008234 RID: 33332 RVA: 0x0022A960 File Offset: 0x00228B60
		// (set) Token: 0x06008235 RID: 33333 RVA: 0x0003DE7E File Offset: 0x0003C07E
		public unsafe Material redLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_redLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x06008236 RID: 33334 RVA: 0x0022A990 File Offset: 0x00228B90
		// (set) Token: 0x06008237 RID: 33335 RVA: 0x0003DE9D File Offset: 0x0003C09D
		public unsafe Material greenLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06008238 RID: 33336 RVA: 0x0022A9C0 File Offset: 0x00228BC0
		// (set) Token: 0x06008239 RID: 33337 RVA: 0x0003DEBC File Offset: 0x0003C0BC
		public unsafe Material greenLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_greenLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600823A RID: 33338 RVA: 0x0022A9F0 File Offset: 0x00228BF0
		// (set) Token: 0x0600823B RID: 33339 RVA: 0x0003DEDB File Offset: 0x0003C0DB
		public unsafe bool wallsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_wallsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_wallsOpen)) = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600823C RID: 33340 RVA: 0x0022AA18 File Offset: 0x00228C18
		// (set) Token: 0x0600823D RID: 33341 RVA: 0x0003DEF6 File Offset: 0x0003C0F6
		public unsafe LandVehicle currentOccupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_currentOccupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_currentOccupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600823E RID: 33342 RVA: 0x0022AA48 File Offset: 0x00228C48
		// (set) Token: 0x0600823F RID: 33343 RVA: 0x0003DF15 File Offset: 0x0003C115
		public unsafe LandVehicle _reservant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__reservant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06008240 RID: 33344 RVA: 0x0022AA78 File Offset: 0x00228C78
		// (set) Token: 0x06008241 RID: 33345 RVA: 0x0003DF34 File Offset: 0x0003C134
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06008242 RID: 33346 RVA: 0x0022AAA0 File Offset: 0x00228CA0
		// (set) Token: 0x06008243 RID: 33347 RVA: 0x0003DF4F File Offset: 0x0003C14F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400587E RID: 22654
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetector;

		// Token: 0x0400587F RID: 22655
		private static readonly IntPtr NativeFieldInfoPtr_redLightMeshes;

		// Token: 0x04005880 RID: 22656
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMeshes;

		// Token: 0x04005881 RID: 22657
		private static readonly IntPtr NativeFieldInfoPtr_sideWalls;

		// Token: 0x04005882 RID: 22658
		private static readonly IntPtr NativeFieldInfoPtr_gateAnim;

		// Token: 0x04005883 RID: 22659
		private static readonly IntPtr NativeFieldInfoPtr_reservationBlocker;

		// Token: 0x04005884 RID: 22660
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePosition;

		// Token: 0x04005885 RID: 22661
		private static readonly IntPtr NativeFieldInfoPtr_redLightMat_On;

		// Token: 0x04005886 RID: 22662
		private static readonly IntPtr NativeFieldInfoPtr_redLightMat_Off;

		// Token: 0x04005887 RID: 22663
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMat_On;

		// Token: 0x04005888 RID: 22664
		private static readonly IntPtr NativeFieldInfoPtr_greenLightMat_Off;

		// Token: 0x04005889 RID: 22665
		private static readonly IntPtr NativeFieldInfoPtr_wallsOpen;

		// Token: 0x0400588A RID: 22666
		private static readonly IntPtr NativeFieldInfoPtr_currentOccupant;

		// Token: 0x0400588B RID: 22667
		private static readonly IntPtr NativeFieldInfoPtr__reservant_k__BackingField;

		// Token: 0x0400588C RID: 22668
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400588D RID: 22669
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400588E RID: 22670
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x0400588F RID: 22671
		private static readonly IntPtr NativeMethodInfoPtr_get_reservant_Public_get_LandVehicle_0;

		// Token: 0x04005890 RID: 22672
		private static readonly IntPtr NativeMethodInfoPtr_set_reservant_Protected_set_Void_LandVehicle_0;

		// Token: 0x04005891 RID: 22673
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005892 RID: 22674
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005893 RID: 22675
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005894 RID: 22676
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04005895 RID: 22677
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005896 RID: 22678
		private static readonly IntPtr NativeMethodInfoPtr_SetReservant_Public_Void_LandVehicle_0;

		// Token: 0x04005897 RID: 22679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005898 RID: 22680
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005899 RID: 22681
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400589A RID: 22682
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400589B RID: 22683
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
