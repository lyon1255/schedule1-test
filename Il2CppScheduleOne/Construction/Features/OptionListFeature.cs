using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000486 RID: 1158
	public class OptionListFeature : Feature
	{
		// Token: 0x06006473 RID: 25715 RVA: 0x001C661C File Offset: 0x001C481C
		// Note: this type is marked as 'beforefieldinit'.
		static OptionListFeature()
		{
			Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "OptionListFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr);
			OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "defaultOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "syncVar___ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676023);
			OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676024);
			OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676025);
			OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676026);
			OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676027);
			OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676028);
			OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676029);
			OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676030);
			OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676031);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676032);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676033);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676034);
			OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676035);
			OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676036);
			OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676037);
			OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676038);
			OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676039);
			OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676040);
			OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676041);
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x001C682C File Offset: 0x001C4A2C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x001C6868 File Offset: 0x001C4A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204198, XrefRangeEnd = 204219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x001C68C4 File Offset: 0x001C4AC4
		[CallerCount(0)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x001C6900 File Offset: 0x001C4B00
		[CallerCount(0)]
		public unsafe virtual List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr3) : null;
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x001C694C File Offset: 0x001C4B4C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x001C6998 File Offset: 0x001C4B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204219, XrefRangeEnd = 204242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x001C69E4 File Offset: 0x001C4BE4
		[CallerCount(0)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x001C6A18 File Offset: 0x001C4C18
		[CallerCount(0)]
		public unsafe virtual void PurchaseOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x001C6A64 File Offset: 0x001C4C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionListFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x001C6AA0 File Offset: 0x001C4CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204265, RefRangeEnd = 204267, XrefRangeStart = 204242, XrefRangeEnd = 204265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x001C6ADC File Offset: 0x001C4CDC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x001C6B18 File Offset: 0x001C4D18
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x001C6B54 File Offset: 0x001C4D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204267, XrefRangeEnd = 204287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x001C6B94 File Offset: 0x001C4D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204295, RefRangeEnd = 204297, XrefRangeStart = 204287, XrefRangeEnd = 204295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x001C6BE0 File Offset: 0x001C4DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204297, XrefRangeEnd = 204302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06006483 RID: 25731 RVA: 0x001C6C44 File Offset: 0x001C4E44
		// (set) Token: 0x06006484 RID: 25732 RVA: 0x001C6C80 File Offset: 0x001C4E80
		public unsafe int SyncAccessor_ownedOptionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204310, RefRangeEnd = 204311, XrefRangeStart = 204302, XrefRangeEnd = 204310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x001C6CCC File Offset: 0x001C4ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204311, XrefRangeEnd = 204316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x001C6D40 File Offset: 0x001C4F40
		[CallerCount(0)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0002F839 File Offset: 0x0002DA39
		public OptionListFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06006488 RID: 25736 RVA: 0x001C6D7C File Offset: 0x001C4F7C
		// (set) Token: 0x06006489 RID: 25737 RVA: 0x0002F842 File Offset: 0x0002DA42
		public unsafe int defaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex)) = value;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600648A RID: 25738 RVA: 0x001C6DA4 File Offset: 0x001C4FA4
		// (set) Token: 0x0600648B RID: 25739 RVA: 0x0002F85D File Offset: 0x0002DA5D
		public unsafe int ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex)) = value;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600648C RID: 25740 RVA: 0x001C6DCC File Offset: 0x001C4FCC
		// (set) Token: 0x0600648D RID: 25741 RVA: 0x0002F878 File Offset: 0x0002DA78
		public unsafe SyncVar<int> syncVar___ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600648E RID: 25742 RVA: 0x001C6DFC File Offset: 0x001C4FFC
		// (set) Token: 0x0600648F RID: 25743 RVA: 0x0002F897 File Offset: 0x0002DA97
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06006490 RID: 25744 RVA: 0x001C6E24 File Offset: 0x001C5024
		// (set) Token: 0x06006491 RID: 25745 RVA: 0x0002F8B2 File Offset: 0x0002DAB2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400448A RID: 17546
		private static readonly IntPtr NativeFieldInfoPtr_defaultOptionIndex;

		// Token: 0x0400448B RID: 17547
		private static readonly IntPtr NativeFieldInfoPtr_ownedOptionIndex;

		// Token: 0x0400448C RID: 17548
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___ownedOptionIndex;

		// Token: 0x0400448D RID: 17549
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400448E RID: 17550
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400448F RID: 17551
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004490 RID: 17552
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x04004491 RID: 17553
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x04004492 RID: 17554
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0;

		// Token: 0x04004493 RID: 17555
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04004494 RID: 17556
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004495 RID: 17557
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x04004496 RID: 17558
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04004497 RID: 17559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004498 RID: 17560
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004499 RID: 17561
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400449A RID: 17562
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400449B RID: 17563
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x0400449C RID: 17564
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400449D RID: 17565
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400449E RID: 17566
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0;

		// Token: 0x0400449F RID: 17567
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x040044A0 RID: 17568
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040044A1 RID: 17569
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
