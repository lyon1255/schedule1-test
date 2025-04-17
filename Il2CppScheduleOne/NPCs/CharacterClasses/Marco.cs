using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000325 RID: 805
	public class Marco : NPC
	{
		// Token: 0x06003B8E RID: 15246 RVA: 0x001320B8 File Offset: 0x001302B8
		// Note: this type is marked as 'beforefieldinit'.
		static Marco()
		{
			Il2CppClassPointerStore<Marco>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Marco");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marco>.NativeClassPtr);
			Marco.NativeFieldInfoPtr_VehicleRecoveryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "VehicleRecoveryPoint");
			Marco.NativeFieldInfoPtr_VehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "VehicleDetector");
			Marco.NativeFieldInfoPtr_RecoveryConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "RecoveryConversation");
			Marco.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "GreetingDialogue");
			Marco.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "GreetedVariable");
			Marco.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted");
			Marco.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marco>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted");
			Marco.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670233);
			Marco.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670234);
			Marco.NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670235);
			Marco.NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670236);
			Marco.NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670237);
			Marco.NativeMethodInfoPtr_RecoverVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670238);
			Marco.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670239);
			Marco.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670240);
			Marco.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670241);
			Marco.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670242);
			Marco.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670243);
			Marco.NativeMethodInfoPtr__Start_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670244);
			Marco.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670245);
			Marco.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670246);
			Marco.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670247);
			Marco.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marco>.NativeClassPtr, 100670248);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x001322B4 File Offset: 0x001304B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142395, XrefRangeEnd = 142396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x001322F0 File Offset: 0x001304F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142396, XrefRangeEnd = 142419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x0013232C File Offset: 0x0013052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142419, XrefRangeEnd = 142428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldShowRecoverVehicle(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00132378 File Offset: 0x00130578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142428, XrefRangeEnd = 142444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RecoverVehicleValid(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x001323D0 File Offset: 0x001305D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142444, XrefRangeEnd = 142453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RepaintVehicleValid(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00132428 File Offset: 0x00130628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142453, XrefRangeEnd = 142462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_RecoverVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x0013245C File Offset: 0x0013065C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142462, XrefRangeEnd = 142491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00132490 File Offset: 0x00130690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142491, XrefRangeEnd = 142503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001324C4 File Offset: 0x001306C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142503, XrefRangeEnd = 142523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001324F8 File Offset: 0x001306F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142523, XrefRangeEnd = 142528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Marco() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marco>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00132534 File Offset: 0x00130734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142528, XrefRangeEnd = 142534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00132568 File Offset: 0x00130768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142534, XrefRangeEnd = 142537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marco.NativeMethodInfoPtr__Start_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x0013259C File Offset: 0x0013079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142537, XrefRangeEnd = 142538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x001325D8 File Offset: 0x001307D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142538, XrefRangeEnd = 142539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00132614 File Offset: 0x00130814
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00132650 File Offset: 0x00130850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142601, RefRangeEnd = 142602, XrefRangeStart = 142539, XrefRangeEnd = 142601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marco.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x0001E49C File Offset: 0x0001C69C
		public Marco(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0013268C File Offset: 0x0013088C
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x0001E4A5 File Offset: 0x0001C6A5
		public unsafe Transform VehicleRecoveryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleRecoveryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleRecoveryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x001326BC File Offset: 0x001308BC
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x0001E4C4 File Offset: 0x0001C6C4
		public unsafe VehicleDetector VehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_VehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x001326EC File Offset: 0x001308EC
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x0001E4E3 File Offset: 0x0001C6E3
		public unsafe DialogueContainer RecoveryConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_RecoveryConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_RecoveryConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x0013271C File Offset: 0x0013091C
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x0001E502 File Offset: 0x0001C702
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x0013274C File Offset: 0x0013094C
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x0001E521 File Offset: 0x0001C721
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x00132774 File Offset: 0x00130974
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x0001E540 File Offset: 0x0001C740
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x0013279C File Offset: 0x0013099C
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x0001E55B File Offset: 0x0001C75B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marco.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeFieldInfoPtr_VehicleRecoveryPoint;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetector;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_RecoveryConversation;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowRecoverVehicle_Private_Boolean_Boolean_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicleValid_Private_Boolean_byref_String_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_RepaintVehicleValid_Private_Boolean_byref_String_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicle_Private_Void_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Private_Void_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
