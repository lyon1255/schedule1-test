using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000512 RID: 1298
	public class RV : Property
	{
		// Token: 0x06007351 RID: 29521 RVA: 0x001F78A0 File Offset: 0x001F5AA0
		// Note: this type is marked as 'beforefieldinit'.
		static RV()
		{
			Il2CppClassPointerStore<RV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "RV");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV>.NativeClassPtr);
			RV.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "ModelContainer");
			RV.NativeFieldInfoPtr_FXContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "FXContainer");
			RV.NativeFieldInfoPtr_onSetExploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "onSetExploded");
			RV.NativeFieldInfoPtr___isExploded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "<_isExploded>k__BackingField");
			RV.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677786);
			RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677787);
			RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677788);
			RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677789);
			RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677790);
			RV.NativeMethodInfoPtr_Ransack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677791);
			RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677792);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677793);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677794);
			RV.NativeMethodInfoPtr_OnSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677795);
			RV.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677796);
			RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677797);
			RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677798);
			RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677799);
			RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677800);
			RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677801);
			RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677802);
			RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100677803);
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06007352 RID: 29522 RVA: 0x001F7AB0 File Offset: 0x001F5CB0
		// (set) Token: 0x06007353 RID: 29523 RVA: 0x001F7AEC File Offset: 0x001F5CEC
		public unsafe bool _isExploded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x001F7B2C File Offset: 0x001F5D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225649, XrefRangeEnd = 225665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x001F7B68 File Offset: 0x001F5D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225665, XrefRangeEnd = 225666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x001F7BB8 File Offset: 0x001F5DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225666, XrefRangeEnd = 225761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x001F7BEC File Offset: 0x001F5DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225814, RefRangeEnd = 225815, XrefRangeStart = 225761, XrefRangeEnd = 225814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ransack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_Ransack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x001F7C20 File Offset: 0x001F5E20
		[CallerCount(0)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x001F7C68 File Offset: 0x001F5E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225815, XrefRangeEnd = 225833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x001F7CAC File Offset: 0x001F5EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225833, XrefRangeEnd = 225834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x001F7CE0 File Offset: 0x001F5EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225834, XrefRangeEnd = 225840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_OnSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x001F7D14 File Offset: 0x001F5F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225840, XrefRangeEnd = 225844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RV() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x001F7D50 File Offset: 0x001F5F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225844, XrefRangeEnd = 225852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x001F7D8C File Offset: 0x001F5F8C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x001F7DC8 File Offset: 0x001F5FC8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x001F7E04 File Offset: 0x001F6004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x001F7E48 File Offset: 0x001F6048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x001F7E8C File Offset: 0x001F608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225852, XrefRangeEnd = 225855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x001F7EDC File Offset: 0x001F60DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00036D48 File Offset: 0x00034F48
		public RV(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06007365 RID: 29541 RVA: 0x001F7F18 File Offset: 0x001F6118
		// (set) Token: 0x06007366 RID: 29542 RVA: 0x00036D51 File Offset: 0x00034F51
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x001F7F48 File Offset: 0x001F6148
		// (set) Token: 0x06007368 RID: 29544 RVA: 0x00036D70 File Offset: 0x00034F70
		public unsafe Transform FXContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06007369 RID: 29545 RVA: 0x001F7F78 File Offset: 0x001F6178
		// (set) Token: 0x0600736A RID: 29546 RVA: 0x00036D8F File Offset: 0x00034F8F
		public unsafe UnityEvent onSetExploded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600736B RID: 29547 RVA: 0x001F7FA8 File Offset: 0x001F61A8
		// (set) Token: 0x0600736C RID: 29548 RVA: 0x00036DAE File Offset: 0x00034FAE
		public unsafe bool __isExploded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600736D RID: 29549 RVA: 0x001F7FD0 File Offset: 0x001F61D0
		// (set) Token: 0x0600736E RID: 29550 RVA: 0x00036DC9 File Offset: 0x00034FC9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x001F7FF8 File Offset: 0x001F61F8
		// (set) Token: 0x06007370 RID: 29552 RVA: 0x00036DE4 File Offset: 0x00034FE4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004EB8 RID: 20152
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04004EB9 RID: 20153
		private static readonly IntPtr NativeFieldInfoPtr_FXContainer;

		// Token: 0x04004EBA RID: 20154
		private static readonly IntPtr NativeFieldInfoPtr_onSetExploded;

		// Token: 0x04004EBB RID: 20155
		private static readonly IntPtr NativeFieldInfoPtr___isExploded_k__BackingField;

		// Token: 0x04004EBC RID: 20156
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004EBD RID: 20157
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004EBE RID: 20158
		private static readonly IntPtr NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0;

		// Token: 0x04004EBF RID: 20159
		private static readonly IntPtr NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0;

		// Token: 0x04004EC0 RID: 20160
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004EC1 RID: 20161
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004EC2 RID: 20162
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04004EC3 RID: 20163
		private static readonly IntPtr NativeMethodInfoPtr_Ransack_Public_Void_0;

		// Token: 0x04004EC4 RID: 20164
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04004EC5 RID: 20165
		private static readonly IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0;

		// Token: 0x04004EC6 RID: 20166
		private static readonly IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_0;

		// Token: 0x04004EC7 RID: 20167
		private static readonly IntPtr NativeMethodInfoPtr_OnSleep_Private_Void_0;

		// Token: 0x04004EC8 RID: 20168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004EC9 RID: 20169
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004ECA RID: 20170
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004ECB RID: 20171
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004ECC RID: 20172
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04004ECD RID: 20173
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04004ECE RID: 20174
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004ECF RID: 20175
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A8B RID: 2699
		[ObfuscatedName("ScheduleOne.Property.RV+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D247 RID: 53831 RVA: 0x00324F44 File Offset: 0x00323144
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RV.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RV>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV.__c>.NativeClassPtr);
				RV.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9");
				RV.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_0");
				RV.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_1");
				RV.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_2");
				RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677805);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677806);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677807);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100677808);
			}

			// Token: 0x0600D248 RID: 53832 RVA: 0x00325010 File Offset: 0x00323210
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D249 RID: 53833 RVA: 0x0032504C File Offset: 0x0032324C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225643, XrefRangeEnd = 225644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D24A RID: 53834 RVA: 0x0032509C File Offset: 0x0032329C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225644, XrefRangeEnd = 225645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__9_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}

			// Token: 0x0600D24B RID: 53835 RVA: 0x003250EC File Offset: 0x003232EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225645, XrefRangeEnd = 225649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_2(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D24C RID: 53836 RVA: 0x0006660C File Offset: 0x0006480C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413F RID: 16703
			// (get) Token: 0x0600D24D RID: 53837 RVA: 0x0032513C File Offset: 0x0032333C
			// (set) Token: 0x0600D24E RID: 53838 RVA: 0x00066615 File Offset: 0x00064815
			public unsafe static RV.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004140 RID: 16704
			// (get) Token: 0x0600D24F RID: 53839 RVA: 0x00325164 File Offset: 0x00323364
			// (set) Token: 0x0600D250 RID: 53840 RVA: 0x00066627 File Offset: 0x00064827
			public unsafe static Func<BuildableItem, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004141 RID: 16705
			// (get) Token: 0x0600D251 RID: 53841 RVA: 0x0032518C File Offset: 0x0032338C
			// (set) Token: 0x0600D252 RID: 53842 RVA: 0x00066639 File Offset: 0x00064839
			public unsafe static Func<BuildableItem, Pot> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004142 RID: 16706
			// (get) Token: 0x0600D253 RID: 53843 RVA: 0x003251B4 File Offset: 0x003233B4
			// (set) Token: 0x0600D254 RID: 53844 RVA: 0x0006664B File Offset: 0x0006484B
			public unsafe static Predicate<Additive> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD0 RID: 36304
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DD1 RID: 36305
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008DD2 RID: 36306
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04008DD3 RID: 36307
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04008DD4 RID: 36308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD5 RID: 36309
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04008DD6 RID: 36310
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04008DD7 RID: 36311
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0;
		}
	}
}
