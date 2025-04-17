using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039A RID: 922
	public class IConfigurable : Il2CppObjectBase
	{
		// Token: 0x06004850 RID: 18512 RVA: 0x00161A24 File Offset: 0x0015FC24
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurable()
		{
			Il2CppClassPointerStore<IConfigurable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "IConfigurable");
			IConfigurable.NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672238);
			IConfigurable.NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672239);
			IConfigurable.NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672240);
			IConfigurable.NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672241);
			IConfigurable.NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672242);
			IConfigurable.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672243);
			IConfigurable.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672244);
			IConfigurable.NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672245);
			IConfigurable.NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672246);
			IConfigurable.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672247);
			IConfigurable.NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672248);
			IConfigurable.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672249);
			IConfigurable.NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672250);
			IConfigurable.NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672251);
			IConfigurable.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672252);
			IConfigurable.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672253);
			IConfigurable.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672254);
			IConfigurable.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672255);
			IConfigurable.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672256);
			IConfigurable.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672257);
			IConfigurable.NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672258);
			IConfigurable.NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurable>.NativeClassPtr, 100672259);
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00161C04 File Offset: 0x0015FE04
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x00161C50 File Offset: 0x0015FE50
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x00161C9C File Offset: 0x0015FE9C
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x00161CE4 File Offset: 0x0015FEE4
		// (set) Token: 0x06004855 RID: 18517 RVA: 0x00161D30 File Offset: 0x0015FF30
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x00161D80 File Offset: 0x0015FF80
		// (set) Token: 0x06004857 RID: 18519 RVA: 0x00161DCC File Offset: 0x0015FFCC
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x00161E1C File Offset: 0x0016001C
		public unsafe virtual bool IsBeingConfiguredByOtherPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162045, XrefRangeEnd = 162052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x00161E64 File Offset: 0x00160064
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x00161EB0 File Offset: 0x001600B0
		public unsafe virtual Transform Transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x00161EFC File Offset: 0x001600FC
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x00161F48 File Offset: 0x00160148
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162052, XrefRangeEnd = 162054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x00161F90 File Offset: 0x00160190
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00161FD8 File Offset: 0x001601D8
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00162024 File Offset: 0x00160224
		[CallerCount(0)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00162070 File Offset: 0x00160270
		[CallerCount(0)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x001620AC File Offset: 0x001602AC
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001620F8 File Offset: 0x001602F8
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00162134 File Offset: 0x00160334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162054, XrefRangeEnd = 162058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00162170 File Offset: 0x00160370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162058, XrefRangeEnd = 162062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x001621AC File Offset: 0x001603AC
		[CallerCount(0)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x001621FC File Offset: 0x001603FC
		[CallerCount(0)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurable.NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00022F3D File Offset: 0x0002113D
		public IConfigurable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Abstract_Virtual_New_get_EntityConfiguration_0;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Abstract_Virtual_New_get_ConfigurationReplicator_0;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Abstract_Virtual_New_get_EConfigurableType_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Abstract_Virtual_New_get_WorldspaceUIElement_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Abstract_Virtual_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBeingConfiguredByOtherPlayer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Abstract_Virtual_New_get_Sprite_0;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Abstract_Virtual_New_get_Property_0;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Abstract_Virtual_New_WorldspaceUIElement_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Abstract_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Abstract_Virtual_New_Void_NetworkConnection_0;
	}
}
