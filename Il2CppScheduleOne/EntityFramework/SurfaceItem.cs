using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000401 RID: 1025
	public class SurfaceItem : BuildableItem
	{
		// Token: 0x06005609 RID: 22025 RVA: 0x001923C0 File Offset: 0x001905C0
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItem()
		{
			Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr);
			SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<ParentSurface>k__BackingField");
			SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "ValidSurfaceTypes");
			SurfaceItem.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "AllowRotation");
			SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<RotationIncrement>k__BackingField");
			SurfaceItem.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "RelativePosition");
			SurfaceItem.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "RelativeRotation");
			SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted");
			SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted");
			SurfaceItem.NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674066);
			SurfaceItem.NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674067);
			SurfaceItem.NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674068);
			SurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674069);
			SurfaceItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674070);
			SurfaceItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674071);
			SurfaceItem.NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674072);
			SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674073);
			SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674074);
			SurfaceItem.NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674075);
			SurfaceItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674076);
			SurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674077);
			SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674078);
			SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674079);
			SurfaceItem.NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674080);
			SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674081);
			SurfaceItem.NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674082);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674083);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674084);
			SurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674085);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674086);
			SurfaceItem.NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674087);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674088);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674089);
			SurfaceItem.NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674090);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674091);
			SurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674092);
			SurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674093);
			SurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, 100674094);
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x001926D4 File Offset: 0x001908D4
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x00192714 File Offset: 0x00190914
		public unsafe Surface ParentSurface
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x00192758 File Offset: 0x00190958
		public unsafe float RotationIncrement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00192794 File Offset: 0x00190994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182611, RefRangeEnd = 182612, XrefRangeStart = 182611, XrefRangeEnd = 182611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x001927D0 File Offset: 0x001909D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182612, XrefRangeEnd = 182619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x0019280C File Offset: 0x00190A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182619, XrefRangeEnd = 182621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x0019285C File Offset: 0x00190A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182621, XrefRangeEnd = 182622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSurfaceItemData(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x001928E0 File Offset: 0x00190AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182622, XrefRangeEnd = 182623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSurfaceItem(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00192980 File Offset: 0x00190B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182623, XrefRangeEnd = 182642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00192A10 File Offset: 0x00190C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182642, XrefRangeEnd = 182671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00192A7C File Offset: 0x00190C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182671, XrefRangeEnd = 182672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00192AD8 File Offset: 0x00190CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182672, XrefRangeEnd = 182677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00192B1C File Offset: 0x00190D1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182698, RefRangeEnd = 182701, XrefRangeStart = 182677, XrefRangeEnd = 182698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00192B58 File Offset: 0x00190D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182701, XrefRangeEnd = 182706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00192B98 File Offset: 0x00190D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x00192BD4 File Offset: 0x00190DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182706, XrefRangeEnd = 182711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00192C14 File Offset: 0x00190E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetTransformData_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00192C50 File Offset: 0x00190E50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182732, RefRangeEnd = 182735, XrefRangeStart = 182711, XrefRangeEnd = 182732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00192C8C File Offset: 0x00190E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182735, RefRangeEnd = 182736, XrefRangeStart = 182735, XrefRangeEnd = 182735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00192CC8 File Offset: 0x00190EC8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00192D04 File Offset: 0x00190F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182763, RefRangeEnd = 182765, XrefRangeStart = 182736, XrefRangeEnd = 182763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00192D88 File Offset: 0x00190F88
		[CallerCount(0)]
		public unsafe void RpcLogic___SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00192E0C File Offset: 0x0019100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182765, XrefRangeEnd = 182774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSurfaceItemData_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00192E70 File Offset: 0x00191070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182801, RefRangeEnd = 182802, XrefRangeStart = 182774, XrefRangeEnd = 182801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x00192F08 File Offset: 0x00191108
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00192FA8 File Offset: 0x001911A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182802, XrefRangeEnd = 182812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00192FF8 File Offset: 0x001911F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182812, XrefRangeEnd = 182839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00193090 File Offset: 0x00191290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182839, XrefRangeEnd = 182849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x001930E0 File Offset: 0x001912E0
		[CallerCount(0)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00029222 File Offset: 0x00027422
		public SurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x0019311C File Offset: 0x0019131C
		// (set) Token: 0x06005629 RID: 22057 RVA: 0x0002922B File Offset: 0x0002742B
		public unsafe Surface _ParentSurface_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__ParentSurface_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x0019314C File Offset: 0x0019134C
		// (set) Token: 0x0600562B RID: 22059 RVA: 0x0002924A File Offset: 0x0002744A
		public unsafe List<Surface.ESurfaceType> ValidSurfaceTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.ESurfaceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_ValidSurfaceTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x0019317C File Offset: 0x0019137C
		// (set) Token: 0x0600562D RID: 22061 RVA: 0x00029269 File Offset: 0x00027469
		public unsafe bool AllowRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x001931A4 File Offset: 0x001913A4
		// (set) Token: 0x0600562F RID: 22063 RVA: 0x00029284 File Offset: 0x00027484
		public unsafe float _RotationIncrement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr__RotationIncrement_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06005630 RID: 22064 RVA: 0x001931CC File Offset: 0x001913CC
		// (set) Token: 0x06005631 RID: 22065 RVA: 0x0002929F File Offset: 0x0002749F
		public unsafe Vector3 RelativePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x001931F4 File Offset: 0x001913F4
		// (set) Token: 0x06005633 RID: 22067 RVA: 0x000292BA File Offset: 0x000274BA
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06005634 RID: 22068 RVA: 0x0019321C File Offset: 0x0019141C
		// (set) Token: 0x06005635 RID: 22069 RVA: 0x000292D5 File Offset: 0x000274D5
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x00193244 File Offset: 0x00191444
		// (set) Token: 0x06005637 RID: 22071 RVA: 0x000292F0 File Offset: 0x000274F0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeFieldInfoPtr__ParentSurface_k__BackingField;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeFieldInfoPtr_ValidSurfaceTypes;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeFieldInfoPtr__RotationIncrement_k__BackingField;

		// Token: 0x04003A5D RID: 14941
		private static readonly IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x04003A5E RID: 14942
		private static readonly IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x04003A5F RID: 14943
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003A60 RID: 14944
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003A61 RID: 14945
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentSurface_Public_get_Surface_0;

		// Token: 0x04003A62 RID: 14946
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentSurface_Protected_set_Void_Surface_0;

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationIncrement_Public_get_Single_0;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeMethodInfoPtr_SendSurfaceItemData_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSurfaceItem_Public_Virtual_New_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformData_Protected_Virtual_New_Void_String_Vector3_Quaternion_0;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeMethodInfoPtr__OnStartClient_b__12_1_Private_Boolean_0;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr__SetTransformData_b__17_1_Private_Boolean_0;

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSurfaceItemData_2652836379_Private_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSurfaceItemData_2652836379_Public_Void_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSurfaceItemData_2652836379_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeSurfaceItem_2932264618_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeSurfaceItem_2932264618_Private_Void_NetworkConnection_ItemInstance_String_String_Vector3_Quaternion_0;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeSurfaceItem_2932264618_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009C4 RID: 2500
		[ObfuscatedName("ScheduleOne.EntityFramework.SurfaceItem+<<OnStartClient>g__WaitForDataSend|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC6D RID: 52333 RVA: 0x00314C44 File Offset: 0x00312E44
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674095);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674096);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674097);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674098);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674099);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674100);
			}

			// Token: 0x0600CC6E RID: 52334 RVA: 0x00314D24 File Offset: 0x00312F24
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC6F RID: 52335 RVA: 0x00314D6C File Offset: 0x00312F6C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC70 RID: 52336 RVA: 0x00314DA0 File Offset: 0x00312FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182575, XrefRangeEnd = 182590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FB3 RID: 16307
			// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x00314DDC File Offset: 0x00312FDC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC72 RID: 52338 RVA: 0x00314E1C File Offset: 0x0031301C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182590, XrefRangeEnd = 182595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FB4 RID: 16308
			// (get) Token: 0x0600CC73 RID: 52339 RVA: 0x00314E50 File Offset: 0x00313050
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC74 RID: 52340 RVA: 0x000636C3 File Offset: 0x000618C3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FB0 RID: 16304
			// (get) Token: 0x0600CC75 RID: 52341 RVA: 0x00314E90 File Offset: 0x00313090
			// (set) Token: 0x0600CC76 RID: 52342 RVA: 0x000636CC File Offset: 0x000618CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FB1 RID: 16305
			// (get) Token: 0x0600CC77 RID: 52343 RVA: 0x00314EB8 File Offset: 0x003130B8
			// (set) Token: 0x0600CC78 RID: 52344 RVA: 0x000636E7 File Offset: 0x000618E7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB2 RID: 16306
			// (get) Token: 0x0600CC79 RID: 52345 RVA: 0x00314EE8 File Offset: 0x003130E8
			// (set) Token: 0x0600CC7A RID: 52346 RVA: 0x00063706 File Offset: 0x00061906
			public unsafe SurfaceItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A31 RID: 35377
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A32 RID: 35378
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A33 RID: 35379
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A34 RID: 35380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A35 RID: 35381
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A36 RID: 35382
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A37 RID: 35383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A38 RID: 35384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A39 RID: 35385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009C5 RID: 2501
		[ObfuscatedName("ScheduleOne.EntityFramework.SurfaceItem+<<SetTransformData>g__Routine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600CC7B RID: 52347 RVA: 0x00314F18 File Offset: 0x00313118
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurfaceItem>.NativeClassPtr, "<<SetTransformData>g__Routine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674101);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674102);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674103);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674104);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674105);
				SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674106);
			}

			// Token: 0x0600CC7C RID: 52348 RVA: 0x00314FF8 File Offset: 0x003131F8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC7D RID: 52349 RVA: 0x00315040 File Offset: 0x00313240
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC7E RID: 52350 RVA: 0x00315074 File Offset: 0x00313274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182595, XrefRangeEnd = 182606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FB8 RID: 16312
			// (get) Token: 0x0600CC7F RID: 52351 RVA: 0x003150B0 File Offset: 0x003132B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC80 RID: 52352 RVA: 0x003150F0 File Offset: 0x003132F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182606, XrefRangeEnd = 182611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FB9 RID: 16313
			// (get) Token: 0x0600CC81 RID: 52353 RVA: 0x00315124 File Offset: 0x00313324
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC82 RID: 52354 RVA: 0x00063725 File Offset: 0x00061925
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FB5 RID: 16309
			// (get) Token: 0x0600CC83 RID: 52355 RVA: 0x00315164 File Offset: 0x00313364
			// (set) Token: 0x0600CC84 RID: 52356 RVA: 0x0006372E File Offset: 0x0006192E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FB6 RID: 16310
			// (get) Token: 0x0600CC85 RID: 52357 RVA: 0x0031518C File Offset: 0x0031338C
			// (set) Token: 0x0600CC86 RID: 52358 RVA: 0x00063749 File Offset: 0x00061949
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB7 RID: 16311
			// (get) Token: 0x0600CC87 RID: 52359 RVA: 0x003151BC File Offset: 0x003133BC
			// (set) Token: 0x0600CC88 RID: 52360 RVA: 0x00063768 File Offset: 0x00061968
			public unsafe SurfaceItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A3A RID: 35386
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A3B RID: 35387
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A3C RID: 35388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A3D RID: 35389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A3E RID: 35390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A3F RID: 35391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A40 RID: 35392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A41 RID: 35393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A42 RID: 35394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
