using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FF RID: 1023
	public class LabelledSurfaceItem : SurfaceItem
	{
		// Token: 0x060055AF RID: 21935 RVA: 0x00190918 File Offset: 0x0018EB18
		// Note: this type is marked as 'beforefieldinit'.
		static LabelledSurfaceItem()
		{
			Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "LabelledSurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr);
			LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "<Message>k__BackingField");
			LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "MaxCharacters");
			LabelledSurfaceItem.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "Label");
			LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted");
			LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted");
			LabelledSurfaceItem.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673989);
			LabelledSurfaceItem.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673990);
			LabelledSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673991);
			LabelledSurfaceItem.NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673992);
			LabelledSurfaceItem.NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673993);
			LabelledSurfaceItem.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673994);
			LabelledSurfaceItem.NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673995);
			LabelledSurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673996);
			LabelledSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673997);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673998);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673999);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674000);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674001);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674002);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674003);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674004);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674005);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674006);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674007);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674008);
			LabelledSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100674009);
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x00190B50 File Offset: 0x0018ED50
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x00190B88 File Offset: 0x0018ED88
		public unsafe string Message
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 166204, RefRangeEnd = 166213, XrefRangeStart = 166204, XrefRangeEnd = 166213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181928, XrefRangeEnd = 181929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00190BCC File Offset: 0x0018EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181929, XrefRangeEnd = 181933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00190C1C File Offset: 0x0018EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181933, XrefRangeEnd = 181955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageToServer(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00190C60 File Offset: 0x0018EE60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181965, RefRangeEnd = 181971, XrefRangeStart = 181955, XrefRangeEnd = 181965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00190CB4 File Offset: 0x0018EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181971, XrefRangeEnd = 181984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00190CE8 File Offset: 0x0018EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MessageSubmitted(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00190D2C File Offset: 0x0018EF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181984, XrefRangeEnd = 181989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00190D70 File Offset: 0x0018EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181989, XrefRangeEnd = 181994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelledSurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00190DAC File Offset: 0x0018EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181994, XrefRangeEnd = 182015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00190DE8 File Offset: 0x0018EFE8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00190E24 File Offset: 0x0018F024
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00190E60 File Offset: 0x0018F060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182015, XrefRangeEnd = 182034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00190EA4 File Offset: 0x0018F0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182034, XrefRangeEnd = 182035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessageToServer_3615296227(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00190EE8 File Offset: 0x0018F0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182035, XrefRangeEnd = 182039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00190F4C File Offset: 0x0018F14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182039, XrefRangeEnd = 182058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00190FA0 File Offset: 0x0018F1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182058, XrefRangeEnd = 182059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00190FF4 File Offset: 0x0018F1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182059, XrefRangeEnd = 182063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00191044 File Offset: 0x0018F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182063, XrefRangeEnd = 182082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00191098 File Offset: 0x0018F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182082, XrefRangeEnd = 182086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x001910E8 File Offset: 0x0018F2E8
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00029099 File Offset: 0x00027299
		public LabelledSurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x00191124 File Offset: 0x0018F324
		// (set) Token: 0x060055C7 RID: 21959 RVA: 0x000290A2 File Offset: 0x000272A2
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x0019114C File Offset: 0x0018F34C
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x000290C1 File Offset: 0x000272C1
		public unsafe int MaxCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters)) = value;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x00191174 File Offset: 0x0018F374
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x000290DC File Offset: 0x000272DC
		public unsafe TextMeshPro Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x001911A4 File Offset: 0x0018F3A4
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x000290FB File Offset: 0x000272FB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x001911CC File Offset: 0x0018F3CC
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x00029116 File Offset: 0x00027316
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A10 RID: 14864
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04003A11 RID: 14865
		private static readonly IntPtr NativeFieldInfoPtr_MaxCharacters;

		// Token: 0x04003A12 RID: 14866
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04003A13 RID: 14867
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003A14 RID: 14868
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003A15 RID: 14869
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04003A16 RID: 14870
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Private_set_Void_String_0;

		// Token: 0x04003A17 RID: 14871
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003A18 RID: 14872
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0;

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0;

		// Token: 0x04003A1A RID: 14874
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04003A1B RID: 14875
		private static readonly IntPtr NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0;

		// Token: 0x04003A1C RID: 14876
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003A1D RID: 14877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
