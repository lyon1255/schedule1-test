using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000358 RID: 856
	public class FootPatrolBehaviour : Behaviour
	{
		// Token: 0x060041BB RID: 16827 RVA: 0x00149328 File Offset: 0x00147528
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolBehaviour()
		{
			Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr);
			FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "MOVE_SPEED");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MIN_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MAX_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_ASSET_PATH");
			FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "UseFlashlight");
			FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "flashlightEquipped");
			FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "<Group>k__BackingField");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671301);
			FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671302);
			FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671303);
			FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671304);
			FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671305);
			FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671306);
			FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671307);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671308);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671309);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671310);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671311);
			FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671312);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671313);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671314);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671315);
			FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671316);
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x0014954C File Offset: 0x0014774C
		// (set) Token: 0x060041BD RID: 16829 RVA: 0x0014958C File Offset: 0x0014778C
		public unsafe PatrolGroup Group
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x001495D0 File Offset: 0x001477D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151626, XrefRangeEnd = 151645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0014960C File Offset: 0x0014780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151645, XrefRangeEnd = 151664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x00149648 File Offset: 0x00147848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151664, XrefRangeEnd = 151677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x00149684 File Offset: 0x00147884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151677, XrefRangeEnd = 151694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x001496C0 File Offset: 0x001478C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151694, XrefRangeEnd = 151760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x001496FC File Offset: 0x001478FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151760, XrefRangeEnd = 151768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x0014973C File Offset: 0x0014793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151776, RefRangeEnd = 151777, XrefRangeStart = 151768, XrefRangeEnd = 151776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGroup(PatrolGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x00149780 File Offset: 0x00147980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151792, RefRangeEnd = 151793, XrefRangeStart = 151777, XrefRangeEnd = 151792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x001497BC File Offset: 0x001479BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151793, XrefRangeEnd = 151802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x001497F8 File Offset: 0x001479F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151802, XrefRangeEnd = 151803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00149834 File Offset: 0x00147A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151803, XrefRangeEnd = 151804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x00149870 File Offset: 0x00147A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151804, XrefRangeEnd = 151805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x001498AC File Offset: 0x00147AAC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x001498E8 File Offset: 0x00147AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000204D2 File Offset: 0x0001E6D2
		public FootPatrolBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x00149924 File Offset: 0x00147B24
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x000204DB File Offset: 0x0001E6DB
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00149940 File Offset: 0x00147B40
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x000204E9 File Offset: 0x0001E6E9
		public unsafe static int FLASHLIGHT_MIN_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0014995C File Offset: 0x00147B5C
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x000204F7 File Offset: 0x0001E6F7
		public unsafe int FLASHLIGHT_MAX_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME)) = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00149984 File Offset: 0x00147B84
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x00020512 File Offset: 0x0001E712
		public unsafe static string FLASHLIGHT_ASSET_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x001499A4 File Offset: 0x00147BA4
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x00020524 File Offset: 0x0001E724
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x001499CC File Offset: 0x00147BCC
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x0002053F File Offset: 0x0001E73F
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x001499F4 File Offset: 0x00147BF4
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x0002055A File Offset: 0x0001E75A
		public unsafe PatrolGroup _Group_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x00149A24 File Offset: 0x00147C24
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x00020579 File Offset: 0x0001E779
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x00149A4C File Offset: 0x00147C4C
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x00020594 File Offset: 0x0001E794
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeFieldInfoPtr__Group_k__BackingField;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
