using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000481 RID: 1153
	public class ColorFeature : Feature
	{
		// Token: 0x060063FA RID: 25594 RVA: 0x001C4CC4 File Offset: 0x001C2EC4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorFeature()
		{
			Il2CppClassPointerStore<ColorFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "ColorFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr);
			ColorFeature.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colorTargets");
			ColorFeature.NativeFieldInfoPtr_secondaryTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "secondaryTargets");
			ColorFeature.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "colors");
			ColorFeature.NativeFieldInfoPtr_defaultColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "defaultColorIndex");
			ColorFeature.NativeFieldInfoPtr_ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "syncVar___ownedColorIndex");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted");
			ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675971);
			ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675972);
			ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675973);
			ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675974);
			ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675975);
			ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675976);
			ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675977);
			ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675978);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675979);
			ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675980);
			ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675981);
			ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675982);
			ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675983);
			ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675984);
			ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675985);
			ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675986);
			ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675987);
			ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, 100675988);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x001C4EFC File Offset: 0x001C30FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203847, XrefRangeEnd = 203874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x001C4F58 File Offset: 0x001C3158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203874, XrefRangeEnd = 203881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x001C4F94 File Offset: 0x001C3194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203907, RefRangeEnd = 203908, XrefRangeStart = 203881, XrefRangeEnd = 203907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x001C4FD8 File Offset: 0x001C31D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203912, RefRangeEnd = 203913, XrefRangeStart = 203908, XrefRangeEnd = 203912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ModifyColor(Color original, float sChange, float vChange)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref original;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x001C5034 File Offset: 0x001C3234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203913, XrefRangeEnd = 203936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x001C5080 File Offset: 0x001C3280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203936, XrefRangeEnd = 203941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x001C50B4 File Offset: 0x001C32B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203941, XrefRangeEnd = 203945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyColor(ColorFeature.NamedColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x001C50F8 File Offset: 0x001C32F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203945, XrefRangeEnd = 203971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x001C5134 File Offset: 0x001C3334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203971, XrefRangeEnd = 203994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x001C5170 File Offset: 0x001C3370
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x001C51AC File Offset: 0x001C33AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x001C51E8 File Offset: 0x001C33E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203994, XrefRangeEnd = 204014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x001C5228 File Offset: 0x001C3428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204023, RefRangeEnd = 204025, XrefRangeStart = 204014, XrefRangeEnd = 204023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x001C5274 File Offset: 0x001C3474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204025, XrefRangeEnd = 204030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x001C52D8 File Offset: 0x001C34D8
		// (set) Token: 0x0600640A RID: 25610 RVA: 0x001C5314 File Offset: 0x001C3514
		public unsafe int SyncAccessor_ownedColorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204038, RefRangeEnd = 204039, XrefRangeStart = 204030, XrefRangeEnd = 204038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x001C5360 File Offset: 0x001C3560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204039, XrefRangeEnd = 204044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x001C53D4 File Offset: 0x001C35D4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x0002F47F File Offset: 0x0002D67F
		public ColorFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600640E RID: 25614 RVA: 0x001C5410 File Offset: 0x001C3610
		// (set) Token: 0x0600640F RID: 25615 RVA: 0x0002F488 File Offset: 0x0002D688
		public unsafe List<MeshRenderer> colorTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06006410 RID: 25616 RVA: 0x001C5440 File Offset: 0x001C3640
		// (set) Token: 0x06006411 RID: 25617 RVA: 0x0002F4A7 File Offset: 0x0002D6A7
		public unsafe List<ColorFeature.SecondaryPaintTarget> secondaryTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.SecondaryPaintTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_secondaryTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06006412 RID: 25618 RVA: 0x001C5470 File Offset: 0x001C3670
		// (set) Token: 0x06006413 RID: 25619 RVA: 0x0002F4C6 File Offset: 0x0002D6C6
		public unsafe List<ColorFeature.NamedColor> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06006414 RID: 25620 RVA: 0x001C54A0 File Offset: 0x001C36A0
		// (set) Token: 0x06006415 RID: 25621 RVA: 0x0002F4E5 File Offset: 0x0002D6E5
		public unsafe int defaultColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_defaultColorIndex)) = value;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x001C54C8 File Offset: 0x001C36C8
		// (set) Token: 0x06006417 RID: 25623 RVA: 0x0002F500 File Offset: 0x0002D700
		public unsafe int ownedColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_ownedColorIndex)) = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x001C54F0 File Offset: 0x001C36F0
		// (set) Token: 0x06006419 RID: 25625 RVA: 0x0002F51B File Offset: 0x0002D71B
		public unsafe SyncVar<int> syncVar___ownedColorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_syncVar___ownedColorIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x001C5520 File Offset: 0x001C3720
		// (set) Token: 0x0600641B RID: 25627 RVA: 0x0002F53A File Offset: 0x0002D73A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600641C RID: 25628 RVA: 0x001C5548 File Offset: 0x001C3748
		// (set) Token: 0x0600641D RID: 25629 RVA: 0x0002F555 File Offset: 0x0002D755
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeFieldInfoPtr_colorTargets;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeFieldInfoPtr_secondaryTargets;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeFieldInfoPtr_defaultColorIndex;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeFieldInfoPtr_ownedColorIndex;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___ownedColorIndex;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004442 RID: 17474
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Private_Void_NamedColor_0;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeMethodInfoPtr_ModifyColor_Public_Static_Color_Color_Single_Single_0;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x04004448 RID: 17480
		private static readonly IntPtr NativeMethodInfoPtr_BuyColor_Private_Void_NamedColor_0;

		// Token: 0x04004449 RID: 17481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400444A RID: 17482
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400444B RID: 17483
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400444C RID: 17484
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_ownedColorIndex_Public_get_Int32_0;

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_ownedColorIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04004452 RID: 17490
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_ColorFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004453 RID: 17491
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A2C RID: 2604
		[Serializable]
		public class NamedColor : Il2CppSystem.Object
		{
			// Token: 0x0600CF4B RID: 53067 RVA: 0x0031CD44 File Offset: 0x0031AF44
			// Note: this type is marked as 'beforefieldinit'.
			static NamedColor()
			{
				Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "NamedColor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr);
				ColorFeature.NamedColor.NativeFieldInfoPtr_colorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "colorName");
				ColorFeature.NamedColor.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "color");
				ColorFeature.NamedColor.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, "price");
				ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr, 100675989);
			}

			// Token: 0x0600CF4C RID: 53068 RVA: 0x0031CDC0 File Offset: 0x0031AFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203838, XrefRangeEnd = 203839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.NamedColor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.NamedColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF4D RID: 53069 RVA: 0x00064D69 File Offset: 0x00062F69
			public NamedColor(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700406B RID: 16491
			// (get) Token: 0x0600CF4E RID: 53070 RVA: 0x0031CDFC File Offset: 0x0031AFFC
			// (set) Token: 0x0600CF4F RID: 53071 RVA: 0x00064D72 File Offset: 0x00062F72
			public unsafe string colorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_colorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700406C RID: 16492
			// (get) Token: 0x0600CF50 RID: 53072 RVA: 0x0031CE24 File Offset: 0x0031B024
			// (set) Token: 0x0600CF51 RID: 53073 RVA: 0x00064D91 File Offset: 0x00062F91
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x1700406D RID: 16493
			// (get) Token: 0x0600CF52 RID: 53074 RVA: 0x0031CE4C File Offset: 0x0031B04C
			// (set) Token: 0x0600CF53 RID: 53075 RVA: 0x00064DAC File Offset: 0x00062FAC
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.NamedColor.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008BD8 RID: 35800
			private static readonly IntPtr NativeFieldInfoPtr_colorName;

			// Token: 0x04008BD9 RID: 35801
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008BDA RID: 35802
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008BDB RID: 35803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A2D RID: 2605
		[Serializable]
		public class SecondaryPaintTarget : Il2CppSystem.Object
		{
			// Token: 0x0600CF54 RID: 53076 RVA: 0x0031CE74 File Offset: 0x0031B074
			// Note: this type is marked as 'beforefieldinit'.
			static SecondaryPaintTarget()
			{
				Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorFeature>.NativeClassPtr, "SecondaryPaintTarget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr);
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "colorTargets");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "sChange");
				ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, "vChange");
				ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr, 100675990);
			}

			// Token: 0x0600CF55 RID: 53077 RVA: 0x0031CEF0 File Offset: 0x0031B0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203839, XrefRangeEnd = 203847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecondaryPaintTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorFeature.SecondaryPaintTarget>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorFeature.SecondaryPaintTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF56 RID: 53078 RVA: 0x00064DC7 File Offset: 0x00062FC7
			public SecondaryPaintTarget(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700406E RID: 16494
			// (get) Token: 0x0600CF57 RID: 53079 RVA: 0x0031CF2C File Offset: 0x0031B12C
			// (set) Token: 0x0600CF58 RID: 53080 RVA: 0x00064DD0 File Offset: 0x00062FD0
			public unsafe List<MeshRenderer> colorTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_colorTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406F RID: 16495
			// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x0031CF5C File Offset: 0x0031B15C
			// (set) Token: 0x0600CF5A RID: 53082 RVA: 0x00064DEF File Offset: 0x00062FEF
			public unsafe float sChange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_sChange)) = value;
				}
			}

			// Token: 0x17004070 RID: 16496
			// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x0031CF84 File Offset: 0x0031B184
			// (set) Token: 0x0600CF5C RID: 53084 RVA: 0x00064E0A File Offset: 0x0006300A
			public unsafe float vChange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorFeature.SecondaryPaintTarget.NativeFieldInfoPtr_vChange)) = value;
				}
			}

			// Token: 0x04008BDC RID: 35804
			private static readonly IntPtr NativeFieldInfoPtr_colorTargets;

			// Token: 0x04008BDD RID: 35805
			private static readonly IntPtr NativeFieldInfoPtr_sChange;

			// Token: 0x04008BDE RID: 35806
			private static readonly IntPtr NativeFieldInfoPtr_vChange;

			// Token: 0x04008BDF RID: 35807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
