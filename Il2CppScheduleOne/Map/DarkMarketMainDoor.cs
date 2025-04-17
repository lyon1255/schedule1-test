using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000774 RID: 1908
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x0600B4F8 RID: 46328 RVA: 0x002D0714 File Offset: 0x002CE914
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketMainDoor()
		{
			Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketMainDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr);
			DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<KnockingEnabled>k__BackingField");
			DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "KnockSound");
			DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "InteractableObject");
			DarkMarketMainDoor.NativeFieldInfoPtr_Peephole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Peephole");
			DarkMarketMainDoor.NativeFieldInfoPtr_Igor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Igor");
			DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "FailDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogueNotOpen");
			DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "knockRoutine");
			DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685557);
			DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685558);
			DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685559);
			DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685560);
			DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685561);
			DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685562);
			DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685563);
			DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685564);
			DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685565);
			DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100685566);
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600B4F9 RID: 46329 RVA: 0x002D08C0 File Offset: 0x002CEAC0
		// (set) Token: 0x0600B4FA RID: 46330 RVA: 0x002D08FC File Offset: 0x002CEAFC
		public unsafe bool KnockingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x002D093C File Offset: 0x002CEB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253614, RefRangeEnd = 253615, XrefRangeStart = 253614, XrefRangeEnd = 253615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x002D0970 File Offset: 0x002CEB70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309784, RefRangeEnd = 309786, XrefRangeStart = 309782, XrefRangeEnd = 309784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKnockingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x002D09B0 File Offset: 0x002CEBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309786, XrefRangeEnd = 309794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x002D09E4 File Offset: 0x002CEBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309794, XrefRangeEnd = 309801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x002D0A18 File Offset: 0x002CEC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x002D0A4C File Offset: 0x002CEC4C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162708, RefRangeEnd = 162724, XrefRangeStart = 162708, XrefRangeEnd = 162724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketMainDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x002D0A88 File Offset: 0x002CEC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309801, XrefRangeEnd = 309806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x002D0AC8 File Offset: 0x002CECC8
		[CallerCount(0)]
		public unsafe bool _Knocked_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x00058C4E File Offset: 0x00056E4E
		public DarkMarketMainDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600B504 RID: 46340 RVA: 0x002D0B04 File Offset: 0x002CED04
		// (set) Token: 0x0600B505 RID: 46341 RVA: 0x00058C57 File Offset: 0x00056E57
		public unsafe bool _KnockingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600B506 RID: 46342 RVA: 0x002D0B2C File Offset: 0x002CED2C
		// (set) Token: 0x0600B507 RID: 46343 RVA: 0x00058C72 File Offset: 0x00056E72
		public unsafe AudioSource KnockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600B508 RID: 46344 RVA: 0x002D0B5C File Offset: 0x002CED5C
		// (set) Token: 0x0600B509 RID: 46345 RVA: 0x00058C91 File Offset: 0x00056E91
		public unsafe InteractableObject InteractableObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x002D0B8C File Offset: 0x002CED8C
		// (set) Token: 0x0600B50B RID: 46347 RVA: 0x00058CB0 File Offset: 0x00056EB0
		public unsafe Peephole Peephole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Peephole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x002D0BBC File Offset: 0x002CEDBC
		// (set) Token: 0x0600B50D RID: 46349 RVA: 0x00058CCF File Offset: 0x00056ECF
		public unsafe Igor Igor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Igor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600B50E RID: 46350 RVA: 0x002D0BEC File Offset: 0x002CEDEC
		// (set) Token: 0x0600B50F RID: 46351 RVA: 0x00058CEE File Offset: 0x00056EEE
		public unsafe DialogueContainer FailDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600B510 RID: 46352 RVA: 0x002D0C1C File Offset: 0x002CEE1C
		// (set) Token: 0x0600B511 RID: 46353 RVA: 0x00058D0D File Offset: 0x00056F0D
		public unsafe DialogueContainer SuccessDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600B512 RID: 46354 RVA: 0x002D0C4C File Offset: 0x002CEE4C
		// (set) Token: 0x0600B513 RID: 46355 RVA: 0x00058D2C File Offset: 0x00056F2C
		public unsafe DialogueContainer SuccessDialogueNotOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600B514 RID: 46356 RVA: 0x002D0C7C File Offset: 0x002CEE7C
		// (set) Token: 0x0600B515 RID: 46357 RVA: 0x00058D4B File Offset: 0x00056F4B
		public unsafe Coroutine knockRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079F8 RID: 31224
		private static readonly IntPtr NativeFieldInfoPtr__KnockingEnabled_k__BackingField;

		// Token: 0x040079F9 RID: 31225
		private static readonly IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x040079FA RID: 31226
		private static readonly IntPtr NativeFieldInfoPtr_InteractableObject;

		// Token: 0x040079FB RID: 31227
		private static readonly IntPtr NativeFieldInfoPtr_Peephole;

		// Token: 0x040079FC RID: 31228
		private static readonly IntPtr NativeFieldInfoPtr_Igor;

		// Token: 0x040079FD RID: 31229
		private static readonly IntPtr NativeFieldInfoPtr_FailDialogue;

		// Token: 0x040079FE RID: 31230
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogue;

		// Token: 0x040079FF RID: 31231
		private static readonly IntPtr NativeFieldInfoPtr_SuccessDialogueNotOpen;

		// Token: 0x04007A00 RID: 31232
		private static readonly IntPtr NativeFieldInfoPtr_knockRoutine;

		// Token: 0x04007A01 RID: 31233
		private static readonly IntPtr NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0;

		// Token: 0x04007A02 RID: 31234
		private static readonly IntPtr NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04007A03 RID: 31235
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007A04 RID: 31236
		private static readonly IntPtr NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0;

		// Token: 0x04007A05 RID: 31237
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007A06 RID: 31238
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007A07 RID: 31239
		private static readonly IntPtr NativeMethodInfoPtr_Knocked_Private_Void_0;

		// Token: 0x04007A08 RID: 31240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007A09 RID: 31241
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007A0A RID: 31242
		private static readonly IntPtr NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0;

		// Token: 0x02000BF9 RID: 3065
		[ObfuscatedName("ScheduleOne.Map.DarkMarketMainDoor+<<Knocked>g__Knock|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DFB0 RID: 57264 RVA: 0x0034B1B0 File Offset: 0x003493B0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique()
			{
				Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<<Knocked>g__Knock|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>1__state");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>2__current");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>4__this");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<shouldUnlock>5__2");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685567);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685568);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685569);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685570);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685571);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100685572);
			}

			// Token: 0x0600DFB1 RID: 57265 RVA: 0x0034B2A4 File Offset: 0x003494A4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFB2 RID: 57266 RVA: 0x0034B2EC File Offset: 0x003494EC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFB3 RID: 57267 RVA: 0x0034B320 File Offset: 0x00349520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309680, XrefRangeEnd = 309777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004555 RID: 17749
			// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x0034B35C File Offset: 0x0034955C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFB5 RID: 57269 RVA: 0x0034B39C File Offset: 0x0034959C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309777, XrefRangeEnd = 309782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004556 RID: 17750
			// (get) Token: 0x0600DFB6 RID: 57270 RVA: 0x0034B3D0 File Offset: 0x003495D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFB7 RID: 57271 RVA: 0x0006D14B File Offset: 0x0006B34B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004551 RID: 17745
			// (get) Token: 0x0600DFB8 RID: 57272 RVA: 0x0034B410 File Offset: 0x00349610
			// (set) Token: 0x0600DFB9 RID: 57273 RVA: 0x0006D154 File Offset: 0x0006B354
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004552 RID: 17746
			// (get) Token: 0x0600DFBA RID: 57274 RVA: 0x0034B438 File Offset: 0x00349638
			// (set) Token: 0x0600DFBB RID: 57275 RVA: 0x0006D16F File Offset: 0x0006B36F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004553 RID: 17747
			// (get) Token: 0x0600DFBC RID: 57276 RVA: 0x0034B468 File Offset: 0x00349668
			// (set) Token: 0x0600DFBD RID: 57277 RVA: 0x0006D18E File Offset: 0x0006B38E
			public unsafe DarkMarketMainDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004554 RID: 17748
			// (get) Token: 0x0600DFBE RID: 57278 RVA: 0x0034B498 File Offset: 0x00349698
			// (set) Token: 0x0600DFBF RID: 57279 RVA: 0x0006D1AD File Offset: 0x0006B3AD
			public unsafe bool _shouldUnlock_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2)) = value;
				}
			}

			// Token: 0x040095D1 RID: 38353
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095D2 RID: 38354
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095D3 RID: 38355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095D4 RID: 38356
			private static readonly IntPtr NativeFieldInfoPtr__shouldUnlock_5__2;

			// Token: 0x040095D5 RID: 38357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095D6 RID: 38358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095D7 RID: 38359
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095D8 RID: 38360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095D9 RID: 38361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095DA RID: 38362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
