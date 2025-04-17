using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x0200041E RID: 1054
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x06005CAE RID: 23726 RVA: 0x001AC7D8 File Offset: 0x001AA9D8
		// Note: this type is marked as 'beforefieldinit'.
		static DragManager()
		{
			Il2CppClassPointerStore<DragManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "DragManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragManager>.NativeClassPtr);
			DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DRAGGABLE_OFFSET");
			DragManager.NativeFieldInfoPtr_ThrowSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowSound");
			DragManager.NativeFieldInfoPtr_DragForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DragForce");
			DragManager.NativeFieldInfoPtr_DampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DampingFactor");
			DragManager.NativeFieldInfoPtr_TorqueForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueForce");
			DragManager.NativeFieldInfoPtr_TorqueDampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueDampingFactor");
			DragManager.NativeFieldInfoPtr_ThrowForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowForce");
			DragManager.NativeFieldInfoPtr_MassInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "MassInfluence");
			DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "<CurrentDraggable>k__BackingField");
			DragManager.NativeFieldInfoPtr_AllDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "AllDraggables");
			DragManager.NativeFieldInfoPtr_lastThrownDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastThrownDraggable");
			DragManager.NativeFieldInfoPtr_lastHeldDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastHeldDraggable");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675110);
			DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675111);
			DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675112);
			DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675113);
			DragManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675114);
			DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675115);
			DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675116);
			DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675117);
			DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675118);
			DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675119);
			DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675120);
			DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675121);
			DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675122);
			DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675123);
			DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675124);
			DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675125);
			DragManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675126);
			DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675127);
			DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675128);
			DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675129);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675130);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675131);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675132);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675133);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675134);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675135);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675136);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675137);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675138);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675139);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675140);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675141);
			DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675142);
			DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675143);
			DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675144);
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x001ACBDC File Offset: 0x001AADDC
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x001ACC1C File Offset: 0x001AAE1C
		public unsafe Draggable CurrentDraggable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x001ACC60 File Offset: 0x001AAE60
		public unsafe bool IsDragging
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 195033, RefRangeEnd = 195036, XrefRangeStart = 195029, XrefRangeEnd = 195033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x001ACC9C File Offset: 0x001AAE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195036, XrefRangeEnd = 195064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x001ACCEC File Offset: 0x001AAEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195064, XrefRangeEnd = 195144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x001ACD20 File Offset: 0x001AAF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195144, XrefRangeEnd = 195158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x001ACD54 File Offset: 0x001AAF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195186, RefRangeEnd = 195188, XrefRangeStart = 195158, XrefRangeEnd = 195186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x001ACD90 File Offset: 0x001AAF90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195194, RefRangeEnd = 195195, XrefRangeStart = 195188, XrefRangeEnd = 195194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDraggable(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x001ACDD4 File Offset: 0x001AAFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195201, RefRangeEnd = 195202, XrefRangeStart = 195195, XrefRangeEnd = 195201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x001ACE18 File Offset: 0x001AB018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195219, RefRangeEnd = 195220, XrefRangeStart = 195202, XrefRangeEnd = 195219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x001ACE5C File Offset: 0x001AB05C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195234, RefRangeEnd = 195236, XrefRangeStart = 195220, XrefRangeEnd = 195234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x001ACEC0 File Offset: 0x001AB0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195236, XrefRangeEnd = 195250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x001ACF24 File Offset: 0x001AB124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195268, RefRangeEnd = 195270, XrefRangeStart = 195250, XrefRangeEnd = 195268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x001ACF64 File Offset: 0x001AB164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195270, XrefRangeEnd = 195273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x001ACFD0 File Offset: 0x001AB1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195273, XrefRangeEnd = 195274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x001AD050 File Offset: 0x001AB250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195285, RefRangeEnd = 195287, XrefRangeStart = 195274, XrefRangeEnd = 195285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x001AD08C File Offset: 0x001AB28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195287, XrefRangeEnd = 195297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x001AD0C8 File Offset: 0x001AB2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195297, XrefRangeEnd = 195332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x001AD104 File Offset: 0x001AB304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195332, XrefRangeEnd = 195335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x001AD140 File Offset: 0x001AB340
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x001AD17C File Offset: 0x001AB37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195234, RefRangeEnd = 195236, XrefRangeStart = 195234, XrefRangeEnd = 195236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x001AD1E0 File Offset: 0x001AB3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x001AD244 File Offset: 0x001AB444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195335, XrefRangeEnd = 195355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x001AD2A8 File Offset: 0x001AB4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x001AD30C File Offset: 0x001AB50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195384, RefRangeEnd = 195385, XrefRangeStart = 195355, XrefRangeEnd = 195384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x001AD370 File Offset: 0x001AB570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195385, XrefRangeEnd = 195392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x001AD3C0 File Offset: 0x001AB5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195420, RefRangeEnd = 195422, XrefRangeStart = 195392, XrefRangeEnd = 195420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x001AD42C File Offset: 0x001AB62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195422, XrefRangeEnd = 195424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x001AD498 File Offset: 0x001AB698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195424, XrefRangeEnd = 195437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x001AD4FC File Offset: 0x001AB6FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195465, RefRangeEnd = 195470, XrefRangeStart = 195437, XrefRangeEnd = 195465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x001AD57C File Offset: 0x001AB77C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 195500, RefRangeEnd = 195507, XrefRangeStart = 195470, XrefRangeEnd = 195500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x001AD5FC File Offset: 0x001AB7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195507, XrefRangeEnd = 195519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x001AD64C File Offset: 0x001AB84C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195547, RefRangeEnd = 195549, XrefRangeStart = 195519, XrefRangeEnd = 195547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x001AD6CC File Offset: 0x001AB8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195549, XrefRangeEnd = 195561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x001AD71C File Offset: 0x001AB91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195561, XrefRangeEnd = 195564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x0002BB35 File Offset: 0x00029D35
		public DragManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x001AD758 File Offset: 0x001AB958
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x0002BB3E File Offset: 0x00029D3E
		public unsafe static float DRAGGABLE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x001AD774 File Offset: 0x001AB974
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x0002BB4C File Offset: 0x00029D4C
		public unsafe AudioSourceController ThrowSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x001AD7A4 File Offset: 0x001AB9A4
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x0002BB6B File Offset: 0x00029D6B
		public unsafe float DragForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce)) = value;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06005CD9 RID: 23769 RVA: 0x001AD7CC File Offset: 0x001AB9CC
		// (set) Token: 0x06005CDA RID: 23770 RVA: 0x0002BB86 File Offset: 0x00029D86
		public unsafe float DampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor)) = value;
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x001AD7F4 File Offset: 0x001AB9F4
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x0002BBA1 File Offset: 0x00029DA1
		public unsafe float TorqueForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce)) = value;
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x001AD81C File Offset: 0x001ABA1C
		// (set) Token: 0x06005CDE RID: 23774 RVA: 0x0002BBBC File Offset: 0x00029DBC
		public unsafe float TorqueDampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor)) = value;
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06005CDF RID: 23775 RVA: 0x001AD844 File Offset: 0x001ABA44
		// (set) Token: 0x06005CE0 RID: 23776 RVA: 0x0002BBD7 File Offset: 0x00029DD7
		public unsafe float ThrowForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce)) = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x001AD86C File Offset: 0x001ABA6C
		// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x0002BBF2 File Offset: 0x00029DF2
		public unsafe float MassInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence)) = value;
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x001AD894 File Offset: 0x001ABA94
		// (set) Token: 0x06005CE4 RID: 23780 RVA: 0x0002BC0D File Offset: 0x00029E0D
		public unsafe Draggable _CurrentDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x001AD8C4 File Offset: 0x001ABAC4
		// (set) Token: 0x06005CE6 RID: 23782 RVA: 0x0002BC2C File Offset: 0x00029E2C
		public unsafe List<Draggable> AllDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x001AD8F4 File Offset: 0x001ABAF4
		// (set) Token: 0x06005CE8 RID: 23784 RVA: 0x0002BC4B File Offset: 0x00029E4B
		public unsafe Draggable lastThrownDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x001AD924 File Offset: 0x001ABB24
		// (set) Token: 0x06005CEA RID: 23786 RVA: 0x0002BC6A File Offset: 0x00029E6A
		public unsafe Draggable lastHeldDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x001AD954 File Offset: 0x001ABB54
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x0002BC89 File Offset: 0x00029E89
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x001AD97C File Offset: 0x001ABB7C
		// (set) Token: 0x06005CEE RID: 23790 RVA: 0x0002BCA4 File Offset: 0x00029EA4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003F65 RID: 16229
		private static readonly IntPtr NativeFieldInfoPtr_DRAGGABLE_OFFSET;

		// Token: 0x04003F66 RID: 16230
		private static readonly IntPtr NativeFieldInfoPtr_ThrowSound;

		// Token: 0x04003F67 RID: 16231
		private static readonly IntPtr NativeFieldInfoPtr_DragForce;

		// Token: 0x04003F68 RID: 16232
		private static readonly IntPtr NativeFieldInfoPtr_DampingFactor;

		// Token: 0x04003F69 RID: 16233
		private static readonly IntPtr NativeFieldInfoPtr_TorqueForce;

		// Token: 0x04003F6A RID: 16234
		private static readonly IntPtr NativeFieldInfoPtr_TorqueDampingFactor;

		// Token: 0x04003F6B RID: 16235
		private static readonly IntPtr NativeFieldInfoPtr_ThrowForce;

		// Token: 0x04003F6C RID: 16236
		private static readonly IntPtr NativeFieldInfoPtr_MassInfluence;

		// Token: 0x04003F6D RID: 16237
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDraggable_k__BackingField;

		// Token: 0x04003F6E RID: 16238
		private static readonly IntPtr NativeFieldInfoPtr_AllDraggables;

		// Token: 0x04003F6F RID: 16239
		private static readonly IntPtr NativeFieldInfoPtr_lastThrownDraggable;

		// Token: 0x04003F70 RID: 16240
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldDraggable;

		// Token: 0x04003F71 RID: 16241
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003F72 RID: 16242
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003F73 RID: 16243
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0;

		// Token: 0x04003F74 RID: 16244
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0;

		// Token: 0x04003F75 RID: 16245
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

		// Token: 0x04003F76 RID: 16246
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003F77 RID: 16247
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003F78 RID: 16248
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04003F79 RID: 16249
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0;

		// Token: 0x04003F7A RID: 16250
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0;

		// Token: 0x04003F7B RID: 16251
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0;

		// Token: 0x04003F7C RID: 16252
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0;

		// Token: 0x04003F7D RID: 16253
		private static readonly IntPtr NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F7E RID: 16254
		private static readonly IntPtr NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F7F RID: 16255
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0;

		// Token: 0x04003F80 RID: 16256
		private static readonly IntPtr NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003F85 RID: 16261
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003F86 RID: 16262
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F89 RID: 16265
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F8A RID: 16266
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F8B RID: 16267
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003F8C RID: 16268
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F8F RID: 16271
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F91 RID: 16273
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F92 RID: 16274
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F93 RID: 16275
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003F94 RID: 16276
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F95 RID: 16277
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
