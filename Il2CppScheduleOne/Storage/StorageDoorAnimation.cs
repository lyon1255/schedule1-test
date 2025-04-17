using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000582 RID: 1410
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x06007C28 RID: 31784 RVA: 0x00216034 File Offset: 0x00214234
		// Note: this type is marked as 'beforefieldinit'.
		static StorageDoorAnimation()
		{
			Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageDoorAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr);
			StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overriddeIsOpen");
			StorageDoorAnimation.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overrideState");
			StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "ItemContainer");
			StorageDoorAnimation.NativeFieldInfoPtr_Anims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "Anims");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenSound");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseSound");
			StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678867);
			StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678868);
			StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678869);
			StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678870);
			StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678871);
			StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678872);
			StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678873);
			StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678874);
			StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678875);
			StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678876);
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06007C29 RID: 31785 RVA: 0x002161E0 File Offset: 0x002143E0
		// (set) Token: 0x06007C2A RID: 31786 RVA: 0x0021621C File Offset: 0x0021441C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x0021625C File Offset: 0x0021445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237096, XrefRangeEnd = 237102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x00216290 File Offset: 0x00214490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237102, XrefRangeEnd = 237103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x002162C4 File Offset: 0x002144C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237103, XrefRangeEnd = 237104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x002162F8 File Offset: 0x002144F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237124, RefRangeEnd = 237132, XrefRangeStart = 237104, XrefRangeEnd = 237124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00216338 File Offset: 0x00214538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237132, XrefRangeEnd = 237138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_DisableItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x0021636C File Offset: 0x0021456C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237139, RefRangeEnd = 237140, XrefRangeStart = 237138, XrefRangeEnd = 237139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideState(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x002163AC File Offset: 0x002145AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216803, RefRangeEnd = 216805, XrefRangeStart = 216803, XrefRangeEnd = 216805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x002163E0 File Offset: 0x002145E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageDoorAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x0003AE41 File Offset: 0x00039041
		public StorageDoorAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06007C34 RID: 31796 RVA: 0x0021641C File Offset: 0x0021461C
		// (set) Token: 0x06007C35 RID: 31797 RVA: 0x0003AE4A File Offset: 0x0003904A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x00216444 File Offset: 0x00214644
		// (set) Token: 0x06007C37 RID: 31799 RVA: 0x0003AE65 File Offset: 0x00039065
		public unsafe bool overriddeIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen)) = value;
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06007C38 RID: 31800 RVA: 0x0021646C File Offset: 0x0021466C
		// (set) Token: 0x06007C39 RID: 31801 RVA: 0x0003AE80 File Offset: 0x00039080
		public unsafe bool overrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState)) = value;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06007C3A RID: 31802 RVA: 0x00216494 File Offset: 0x00214694
		// (set) Token: 0x06007C3B RID: 31803 RVA: 0x0003AE9B File Offset: 0x0003909B
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x06007C3C RID: 31804 RVA: 0x002164C4 File Offset: 0x002146C4
		// (set) Token: 0x06007C3D RID: 31805 RVA: 0x0003AEBA File Offset: 0x000390BA
		public unsafe Il2CppReferenceArray<Animation> Anims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x06007C3E RID: 31806 RVA: 0x002164F4 File Offset: 0x002146F4
		// (set) Token: 0x06007C3F RID: 31807 RVA: 0x0003AED9 File Offset: 0x000390D9
		public unsafe AnimationClip OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x06007C40 RID: 31808 RVA: 0x00216524 File Offset: 0x00214724
		// (set) Token: 0x06007C41 RID: 31809 RVA: 0x0003AEF8 File Offset: 0x000390F8
		public unsafe AnimationClip CloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06007C42 RID: 31810 RVA: 0x00216554 File Offset: 0x00214754
		// (set) Token: 0x06007C43 RID: 31811 RVA: 0x0003AF17 File Offset: 0x00039117
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06007C44 RID: 31812 RVA: 0x00216584 File Offset: 0x00214784
		// (set) Token: 0x06007C45 RID: 31813 RVA: 0x0003AF36 File Offset: 0x00039136
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400548E RID: 21646
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400548F RID: 21647
		private static readonly IntPtr NativeFieldInfoPtr_overriddeIsOpen;

		// Token: 0x04005490 RID: 21648
		private static readonly IntPtr NativeFieldInfoPtr_overrideState;

		// Token: 0x04005491 RID: 21649
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005492 RID: 21650
		private static readonly IntPtr NativeFieldInfoPtr_Anims;

		// Token: 0x04005493 RID: 21651
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x04005494 RID: 21652
		private static readonly IntPtr NativeFieldInfoPtr_CloseAnim;

		// Token: 0x04005495 RID: 21653
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04005496 RID: 21654
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04005497 RID: 21655
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005498 RID: 21656
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005499 RID: 21657
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400549A RID: 21658
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400549B RID: 21659
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400549C RID: 21660
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400549D RID: 21661
		private static readonly IntPtr NativeMethodInfoPtr_DisableItems_Private_Void_0;

		// Token: 0x0400549E RID: 21662
		private static readonly IntPtr NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0;

		// Token: 0x0400549F RID: 21663
		private static readonly IntPtr NativeMethodInfoPtr_ResetOverride_Public_Void_0;

		// Token: 0x040054A0 RID: 21664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
