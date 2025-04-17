using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DC RID: 1244
	public class Forklift : LandVehicle
	{
		// Token: 0x06006CB7 RID: 27831 RVA: 0x001E2518 File Offset: 0x001E0718
		// Note: this type is marked as 'beforefieldinit'.
		static Forklift()
		{
			Il2CppClassPointerStore<Forklift>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Forklift");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forklift>.NativeClassPtr);
			Forklift.NativeFieldInfoPtr_steeringWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheel");
			Forklift.NativeFieldInfoPtr_forkRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "forkRb");
			Forklift.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "joint");
			Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheelAngleMultiplier");
			Forklift.NativeFieldInfoPtr_lift_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MinY");
			Forklift.NativeFieldInfoPtr_lift_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MaxY");
			Forklift.NativeFieldInfoPtr_liftMoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "liftMoveRate");
			Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lastFrameTargetForkHeight");
			Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677042);
			Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677043);
			Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677044);
			Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677045);
			Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677046);
			Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677047);
			Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677048);
			Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677049);
			Forklift.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677050);
			Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677051);
			Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677052);
			Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677053);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677054);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677055);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677056);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677057);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677058);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677059);
			Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677060);
			Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677061);
			Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677062);
			Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677063);
			Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677064);
			Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677065);
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006CB8 RID: 27832 RVA: 0x001E2840 File Offset: 0x001E0A40
		// (set) Token: 0x06006CB9 RID: 27833 RVA: 0x001E287C File Offset: 0x001E0A7C
		public unsafe float targetForkHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217238, RefRangeEnd = 217240, XrefRangeStart = 217205, XrefRangeEnd = 217238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x001E28BC File Offset: 0x001E0ABC
		// (set) Token: 0x06006CBB RID: 27835 RVA: 0x001E28F8 File Offset: 0x001E0AF8
		public unsafe float actualForkHeight
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217240, RefRangeEnd = 217245, XrefRangeStart = 217240, XrefRangeEnd = 217240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217278, RefRangeEnd = 217279, XrefRangeStart = 217245, XrefRangeEnd = 217278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x001E2938 File Offset: 0x001E0B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217279, XrefRangeEnd = 217291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x001E2974 File Offset: 0x001E0B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217291, XrefRangeEnd = 217298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x001E29B0 File Offset: 0x001E0BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217298, XrefRangeEnd = 217314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x001E29EC File Offset: 0x001E0BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217314, XrefRangeEnd = 217328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x001E2A28 File Offset: 0x001E0C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217328, XrefRangeEnd = 217329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Forklift() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Forklift>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x001E2A64 File Offset: 0x001E0C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217329, XrefRangeEnd = 217366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x001E2AA0 File Offset: 0x001E0CA0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x001E2ADC File Offset: 0x001E0CDC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x001E2B18 File Offset: 0x001E0D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217366, XrefRangeEnd = 217395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x001E2B58 File Offset: 0x001E0D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217402, RefRangeEnd = 217404, XrefRangeStart = 217395, XrefRangeEnd = 217402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x001E2B98 File Offset: 0x001E0D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217404, XrefRangeEnd = 217409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x001E2BFC File Offset: 0x001E0DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217409, XrefRangeEnd = 217438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x001E2C3C File Offset: 0x001E0E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217445, RefRangeEnd = 217447, XrefRangeStart = 217438, XrefRangeEnd = 217445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x001E2C7C File Offset: 0x001E0E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217447, XrefRangeEnd = 217452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x001E2CE0 File Offset: 0x001E0EE0
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x001E2D1C File Offset: 0x001E0F1C
		public unsafe float SyncAccessor_<targetForkHeight>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217460, RefRangeEnd = 217461, XrefRangeStart = 217452, XrefRangeEnd = 217460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x001E2D68 File Offset: 0x001E0F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217461, XrefRangeEnd = 217465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06006CCD RID: 27853 RVA: 0x001E2DDC File Offset: 0x001E0FDC
		// (set) Token: 0x06006CCE RID: 27854 RVA: 0x001E2E18 File Offset: 0x001E1018
		public unsafe float SyncAccessor_<actualForkHeight>k__BackingField
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217240, RefRangeEnd = 217245, XrefRangeStart = 217240, XrefRangeEnd = 217245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217465, XrefRangeEnd = 217473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x001E2E64 File Offset: 0x001E1064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217473, XrefRangeEnd = 217484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0003375E File Offset: 0x0003195E
		public Forklift(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x001E2EA0 File Offset: 0x001E10A0
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x00033767 File Offset: 0x00031967
		public unsafe Transform steeringWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x001E2ED0 File Offset: 0x001E10D0
		// (set) Token: 0x06006CD4 RID: 27860 RVA: 0x00033786 File Offset: 0x00031986
		public unsafe Rigidbody forkRb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x001E2F00 File Offset: 0x001E1100
		// (set) Token: 0x06006CD6 RID: 27862 RVA: 0x000337A5 File Offset: 0x000319A5
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06006CD7 RID: 27863 RVA: 0x001E2F30 File Offset: 0x001E1130
		// (set) Token: 0x06006CD8 RID: 27864 RVA: 0x000337C4 File Offset: 0x000319C4
		public unsafe float steeringWheelAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier)) = value;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x001E2F58 File Offset: 0x001E1158
		// (set) Token: 0x06006CDA RID: 27866 RVA: 0x000337DF File Offset: 0x000319DF
		public unsafe float lift_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY)) = value;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x001E2F80 File Offset: 0x001E1180
		// (set) Token: 0x06006CDC RID: 27868 RVA: 0x000337FA File Offset: 0x000319FA
		public unsafe float lift_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY)) = value;
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06006CDD RID: 27869 RVA: 0x001E2FA8 File Offset: 0x001E11A8
		// (set) Token: 0x06006CDE RID: 27870 RVA: 0x00033815 File Offset: 0x00031A15
		public unsafe float liftMoveRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate)) = value;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06006CDF RID: 27871 RVA: 0x001E2FD0 File Offset: 0x001E11D0
		// (set) Token: 0x06006CE0 RID: 27872 RVA: 0x00033830 File Offset: 0x00031A30
		public unsafe float _targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x001E2FF8 File Offset: 0x001E11F8
		// (set) Token: 0x06006CE2 RID: 27874 RVA: 0x0003384B File Offset: 0x00031A4B
		public unsafe float lastFrameTargetForkHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight)) = value;
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06006CE3 RID: 27875 RVA: 0x001E3020 File Offset: 0x001E1220
		// (set) Token: 0x06006CE4 RID: 27876 RVA: 0x00033866 File Offset: 0x00031A66
		public unsafe float _actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x001E3048 File Offset: 0x001E1248
		// (set) Token: 0x06006CE6 RID: 27878 RVA: 0x00033881 File Offset: 0x00031A81
		public unsafe SyncVar<float> syncVar____targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06006CE7 RID: 27879 RVA: 0x001E3078 File Offset: 0x001E1278
		// (set) Token: 0x06006CE8 RID: 27880 RVA: 0x000338A0 File Offset: 0x00031AA0
		public unsafe SyncVar<float> syncVar____actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x001E30A8 File Offset: 0x001E12A8
		// (set) Token: 0x06006CEA RID: 27882 RVA: 0x000338BF File Offset: 0x00031ABF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006CEB RID: 27883 RVA: 0x001E30D0 File Offset: 0x001E12D0
		// (set) Token: 0x06006CEC RID: 27884 RVA: 0x000338DA File Offset: 0x00031ADA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004A50 RID: 19024
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheel;

		// Token: 0x04004A51 RID: 19025
		private static readonly IntPtr NativeFieldInfoPtr_forkRb;

		// Token: 0x04004A52 RID: 19026
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04004A53 RID: 19027
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheelAngleMultiplier;

		// Token: 0x04004A54 RID: 19028
		private static readonly IntPtr NativeFieldInfoPtr_lift_MinY;

		// Token: 0x04004A55 RID: 19029
		private static readonly IntPtr NativeFieldInfoPtr_lift_MaxY;

		// Token: 0x04004A56 RID: 19030
		private static readonly IntPtr NativeFieldInfoPtr_liftMoveRate;

		// Token: 0x04004A57 RID: 19031
		private static readonly IntPtr NativeFieldInfoPtr__targetForkHeight_k__BackingField;

		// Token: 0x04004A58 RID: 19032
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameTargetForkHeight;

		// Token: 0x04004A59 RID: 19033
		private static readonly IntPtr NativeFieldInfoPtr__actualForkHeight_k__BackingField;

		// Token: 0x04004A5A RID: 19034
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField;

		// Token: 0x04004A5B RID: 19035
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField;

		// Token: 0x04004A5C RID: 19036
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004A5D RID: 19037
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004A5E RID: 19038
		private static readonly IntPtr NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0;

		// Token: 0x04004A5F RID: 19039
		private static readonly IntPtr NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004A60 RID: 19040
		private static readonly IntPtr NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0;

		// Token: 0x04004A61 RID: 19041
		private static readonly IntPtr NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004A62 RID: 19042
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004A63 RID: 19043
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x04004A64 RID: 19044
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x04004A65 RID: 19045
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A66 RID: 19046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A67 RID: 19047
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004A68 RID: 19048
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004A69 RID: 19049
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004A6A RID: 19050
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004A6B RID: 19051
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004A6C RID: 19052
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004A6D RID: 19053
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004A6E RID: 19054
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004A6F RID: 19055
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004A70 RID: 19056
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004A71 RID: 19057
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004A72 RID: 19058
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004A73 RID: 19059
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004A74 RID: 19060
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004A75 RID: 19061
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
