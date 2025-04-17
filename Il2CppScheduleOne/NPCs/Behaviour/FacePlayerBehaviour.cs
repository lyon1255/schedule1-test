using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000356 RID: 854
	public class FacePlayerBehaviour : Behaviour
	{
		// Token: 0x06004169 RID: 16745 RVA: 0x00147F0C File Offset: 0x0014610C
		// Note: this type is marked as 'beforefieldinit'.
		static FacePlayerBehaviour()
		{
			Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FacePlayerBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr);
			FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "<Player>k__BackingField");
			FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "<Countdown>k__BackingField");
			FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted");
			FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FacePlayerBehaviourAssembly-CSharp.dll_Excuted");
			FacePlayerBehaviour.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671251);
			FacePlayerBehaviour.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671252);
			FacePlayerBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671253);
			FacePlayerBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671254);
			FacePlayerBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671255);
			FacePlayerBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671256);
			FacePlayerBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671257);
			FacePlayerBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671258);
			FacePlayerBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671259);
			FacePlayerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671260);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671261);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671262);
			FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671263);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671264);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671265);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671266);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671267);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671268);
			FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671269);
			FacePlayerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr, 100671270);
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x0014811C File Offset: 0x0014631C
		// (set) Token: 0x0600416B RID: 16747 RVA: 0x0014815C File Offset: 0x0014635C
		public unsafe Player Player
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x001481A0 File Offset: 0x001463A0
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x001481DC File Offset: 0x001463DC
		public unsafe float Countdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x0014821C File Offset: 0x0014641C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151252, RefRangeEnd = 151255, XrefRangeStart = 151229, XrefRangeEnd = 151252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x0014826C File Offset: 0x0014646C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151284, RefRangeEnd = 151285, XrefRangeStart = 151255, XrefRangeEnd = 151284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetLocal(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x001482B0 File Offset: 0x001464B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151285, XrefRangeEnd = 151289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x001482EC File Offset: 0x001464EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151289, XrefRangeEnd = 151299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00148328 File Offset: 0x00146528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00148364 File Offset: 0x00146564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacePlayerBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacePlayerBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x001483A0 File Offset: 0x001465A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151299, XrefRangeEnd = 151314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x001483DC File Offset: 0x001465DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151314, XrefRangeEnd = 151315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00148418 File Offset: 0x00146618
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00148454 File Offset: 0x00146654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151315, XrefRangeEnd = 151335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x001484A4 File Offset: 0x001466A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151353, RefRangeEnd = 151355, XrefRangeStart = 151335, XrefRangeEnd = 151353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x001484F4 File Offset: 0x001466F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151355, XrefRangeEnd = 151360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00148558 File Offset: 0x00146758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151360, XrefRangeEnd = 151379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0014859C File Offset: 0x0014679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151379, XrefRangeEnd = 151389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x001485E0 File Offset: 0x001467E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151389, XrefRangeEnd = 151400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacePlayerBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00148630 File Offset: 0x00146830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacePlayerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00020365 File Offset: 0x0001E565
		public FacePlayerBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x0014866C File Offset: 0x0014686C
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x0002036E File Offset: 0x0001E56E
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x0014869C File Offset: 0x0014689C
		// (set) Token: 0x06004182 RID: 16770 RVA: 0x0002038D File Offset: 0x0001E58D
		public unsafe float _Countdown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField)) = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x001486C4 File Offset: 0x001468C4
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x000203A8 File Offset: 0x0001E5A8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x001486EC File Offset: 0x001468EC
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x000203C3 File Offset: 0x0001E5C3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacePlayerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeFieldInfoPtr__Countdown_k__BackingField;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_get_Countdown_Public_get_Single_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
