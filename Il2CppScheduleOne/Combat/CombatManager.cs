using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x0200048F RID: 1167
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x06006505 RID: 25861 RVA: 0x001C8500 File Offset: 0x001C6700
		// Note: this type is marked as 'beforefieldinit'.
		static CombatManager()
		{
			Il2CppClassPointerStore<CombatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatManager>.NativeClassPtr);
			CombatManager.NativeFieldInfoPtr_MeleeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "MeleeLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionLayerMask");
			CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "RangedWeaponLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionPrefab");
			CombatManager.NativeFieldInfoPtr_explosionIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "explosionIDs");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676087);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676088);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676089);
			CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676090);
			CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676091);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676092);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676093);
			CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676094);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676095);
			CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676096);
			CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676097);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676098);
			CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676099);
			CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676100);
			CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676101);
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x001C86E8 File Offset: 0x001C68E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205323, XrefRangeEnd = 205345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTestExplosion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x001C871C File Offset: 0x001C691C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205347, RefRangeEnd = 205348, XrefRangeStart = 205345, XrefRangeEnd = 205347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x001C8768 File Offset: 0x001C6968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205374, RefRangeEnd = 205376, XrefRangeStart = 205348, XrefRangeEnd = 205374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x001C87C4 File Offset: 0x001C69C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205402, RefRangeEnd = 205405, XrefRangeStart = 205376, XrefRangeEnd = 205402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x001C8820 File Offset: 0x001C6A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205405, XrefRangeEnd = 205417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x001C885C File Offset: 0x001C6A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205417, XrefRangeEnd = 205434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x001C8898 File Offset: 0x001C6A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205434, XrefRangeEnd = 205437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x001C88D4 File Offset: 0x001C6AD4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x001C8910 File Offset: 0x001C6B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205437, XrefRangeEnd = 205452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x001C896C File Offset: 0x001C6B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205452, XrefRangeEnd = 205453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x001C89C8 File Offset: 0x001C6BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205453, XrefRangeEnd = 205462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x001C8A2C File Offset: 0x001C6C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205462, XrefRangeEnd = 205477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x001C8A88 File Offset: 0x001C6C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205493, RefRangeEnd = 205495, XrefRangeStart = 205477, XrefRangeEnd = 205493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x001C8AE4 File Offset: 0x001C6CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205495, XrefRangeEnd = 205504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x001C8B34 File Offset: 0x001C6D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205504, XrefRangeEnd = 205507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x0002FC77 File Offset: 0x0002DE77
		public CombatManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06006516 RID: 25878 RVA: 0x001C8B70 File Offset: 0x001C6D70
		// (set) Token: 0x06006517 RID: 25879 RVA: 0x0002FC80 File Offset: 0x0002DE80
		public unsafe LayerMask MeleeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask)) = value;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x001C8B98 File Offset: 0x001C6D98
		// (set) Token: 0x06006519 RID: 25881 RVA: 0x0002FC9B File Offset: 0x0002DE9B
		public unsafe LayerMask ExplosionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask)) = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x001C8BC0 File Offset: 0x001C6DC0
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x0002FCB6 File Offset: 0x0002DEB6
		public unsafe LayerMask RangedWeaponLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask)) = value;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600651C RID: 25884 RVA: 0x001C8BE8 File Offset: 0x001C6DE8
		// (set) Token: 0x0600651D RID: 25885 RVA: 0x0002FCD1 File Offset: 0x0002DED1
		public unsafe Explosion ExplosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600651E RID: 25886 RVA: 0x001C8C18 File Offset: 0x001C6E18
		// (set) Token: 0x0600651F RID: 25887 RVA: 0x0002FCF0 File Offset: 0x0002DEF0
		public unsafe List<int> explosionIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06006520 RID: 25888 RVA: 0x001C8C48 File Offset: 0x001C6E48
		// (set) Token: 0x06006521 RID: 25889 RVA: 0x0002FD0F File Offset: 0x0002DF0F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06006522 RID: 25890 RVA: 0x001C8C70 File Offset: 0x001C6E70
		// (set) Token: 0x06006523 RID: 25891 RVA: 0x0002FD2A File Offset: 0x0002DF2A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040044EA RID: 17642
		private static readonly IntPtr NativeFieldInfoPtr_MeleeLayerMask;

		// Token: 0x040044EB RID: 17643
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionLayerMask;

		// Token: 0x040044EC RID: 17644
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeaponLayerMask;

		// Token: 0x040044ED RID: 17645
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionPrefab;

		// Token: 0x040044EE RID: 17646
		private static readonly IntPtr NativeFieldInfoPtr_explosionIDs;

		// Token: 0x040044EF RID: 17647
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040044F0 RID: 17648
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040044F1 RID: 17649
		private static readonly IntPtr NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0;

		// Token: 0x040044F2 RID: 17650
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x040044F3 RID: 17651
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044F4 RID: 17652
		private static readonly IntPtr NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044F5 RID: 17653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044F6 RID: 17654
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040044F7 RID: 17655
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040044F8 RID: 17656
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040044F9 RID: 17657
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044FA RID: 17658
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044FB RID: 17659
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040044FC RID: 17660
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044FD RID: 17661
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x040044FE RID: 17662
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044FF RID: 17663
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
