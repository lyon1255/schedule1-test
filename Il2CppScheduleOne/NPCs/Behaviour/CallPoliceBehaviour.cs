using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000342 RID: 834
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06003DEA RID: 15850 RVA: 0x0013A4E4 File Offset: 0x001386E4
		// Note: this type is marked as 'beforefieldinit'.
		static CallPoliceBehaviour()
		{
			Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CallPoliceBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr);
			CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CALL_POLICE_TIME");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhoneCallPopup");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhonePrefab");
			CallPoliceBehaviour.NativeFieldInfoPtr_CallSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CallSound");
			CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "currentCallTime");
			CallPoliceBehaviour.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "Target");
			CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "ReportedCrime");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670544);
			CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670545);
			CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670546);
			CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670547);
			CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670548);
			CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670549);
			CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670550);
			CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670551);
			CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670552);
			CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670553);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670554);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670555);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670556);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670557);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670558);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670559);
			CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670560);
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x0013A71C File Offset: 0x0013891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145564, XrefRangeEnd = 145585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x0013A758 File Offset: 0x00138958
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkObject player, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x0013A7AC File Offset: 0x001389AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145585, XrefRangeEnd = 145593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x0013A7E8 File Offset: 0x001389E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145593, XrefRangeEnd = 145601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x0013A824 File Offset: 0x00138A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145601, XrefRangeEnd = 145609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x0013A860 File Offset: 0x00138A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145609, XrefRangeEnd = 145634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x0013A89C File Offset: 0x00138A9C
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x0013A8D0 File Offset: 0x00138AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145634, XrefRangeEnd = 145655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x0013A904 File Offset: 0x00138B04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145659, RefRangeEnd = 145662, XrefRangeStart = 145655, XrefRangeEnd = 145659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x0013A940 File Offset: 0x00138B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145662, XrefRangeEnd = 145663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallPoliceBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x0013A97C File Offset: 0x00138B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145663, XrefRangeEnd = 145671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x0013A9B8 File Offset: 0x00138BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145671, XrefRangeEnd = 145672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x0013A9F4 File Offset: 0x00138BF4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0013AA30 File Offset: 0x00138C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145672, XrefRangeEnd = 145690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x0013AA64 File Offset: 0x00138C64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145708, RefRangeEnd = 145711, XrefRangeStart = 145690, XrefRangeEnd = 145708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x0013AA98 File Offset: 0x00138C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145711, XrefRangeEnd = 145714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x0013AAE8 File Offset: 0x00138CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145714, XrefRangeEnd = 145715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x0001F281 File Offset: 0x0001D481
		public CallPoliceBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x0013AB24 File Offset: 0x00138D24
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x0001F28A File Offset: 0x0001D48A
		public unsafe static float CALL_POLICE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x0013AB40 File Offset: 0x00138D40
		// (set) Token: 0x06003E00 RID: 15872 RVA: 0x0001F298 File Offset: 0x0001D498
		public unsafe WorldspacePopup PhoneCallPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x0013AB70 File Offset: 0x00138D70
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x0001F2B7 File Offset: 0x0001D4B7
		public unsafe AvatarEquippable PhonePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x0013ABA0 File Offset: 0x00138DA0
		// (set) Token: 0x06003E04 RID: 15876 RVA: 0x0001F2D6 File Offset: 0x0001D4D6
		public unsafe AudioSourceController CallSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x0013ABD0 File Offset: 0x00138DD0
		// (set) Token: 0x06003E06 RID: 15878 RVA: 0x0001F2F5 File Offset: 0x0001D4F5
		public unsafe float currentCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime)) = value;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x0013ABF8 File Offset: 0x00138DF8
		// (set) Token: 0x06003E08 RID: 15880 RVA: 0x0001F310 File Offset: 0x0001D510
		public unsafe Player Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x0013AC28 File Offset: 0x00138E28
		// (set) Token: 0x06003E0A RID: 15882 RVA: 0x0001F32F File Offset: 0x0001D52F
		public unsafe Crime ReportedCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Crime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x0013AC58 File Offset: 0x00138E58
		// (set) Token: 0x06003E0C RID: 15884 RVA: 0x0001F34E File Offset: 0x0001D54E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x0013AC80 File Offset: 0x00138E80
		// (set) Token: 0x06003E0E RID: 15886 RVA: 0x0001F369 File Offset: 0x0001D569
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeFieldInfoPtr_CALL_POLICE_TIME;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeFieldInfoPtr_PhoneCallPopup;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeFieldInfoPtr_PhonePrefab;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeFieldInfoPtr_CallSound;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeFieldInfoPtr_currentCallTime;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeFieldInfoPtr_ReportedCrime;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCall_Private_Void_0;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
