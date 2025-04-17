using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062A RID: 1578
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x06008B21 RID: 35617 RVA: 0x002467E8 File Offset: 0x002449E8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterDisplay()
		{
			Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr);
			CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AlignmentPoints");
			CharacterDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Container");
			CharacterDisplay.NativeFieldInfoPtr_ParentAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "ParentAvatar");
			CharacterDisplay.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "Avatar");
			CharacterDisplay.NativeFieldInfoPtr_AvatarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "AvatarContainer");
			CharacterDisplay.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "targetRotation");
			CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680580);
			CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680581);
			CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680582);
			CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680583);
			CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680584);
			CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680585);
			CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680586);
			CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100680587);
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x00246944 File Offset: 0x00244B44
		// (set) Token: 0x06008B23 RID: 35619 RVA: 0x00246980 File Offset: 0x00244B80
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x002469C0 File Offset: 0x00244BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254761, XrefRangeEnd = 254782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x002469FC File Offset: 0x00244BFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254804, RefRangeEnd = 254809, XrefRangeStart = 254782, XrefRangeEnd = 254804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x00246A3C File Offset: 0x00244C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254809, XrefRangeEnd = 254817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x00246A70 File Offset: 0x00244C70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254845, RefRangeEnd = 254848, XrefRangeStart = 254817, XrefRangeEnd = 254845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x00246AB4 File Offset: 0x00244CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254848, XrefRangeEnd = 254851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x00246AF0 File Offset: 0x00244CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254851, XrefRangeEnd = 254853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x000429A1 File Offset: 0x00040BA1
		public CharacterDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06008B2B RID: 35627 RVA: 0x00246B24 File Offset: 0x00244D24
		// (set) Token: 0x06008B2C RID: 35628 RVA: 0x000429AA File Offset: 0x00040BAA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06008B2D RID: 35629 RVA: 0x00246B4C File Offset: 0x00244D4C
		// (set) Token: 0x06008B2E RID: 35630 RVA: 0x000429C5 File Offset: 0x00040BC5
		public unsafe Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint> AlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterDisplay.SlotAlignmentPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x00246B7C File Offset: 0x00244D7C
		// (set) Token: 0x06008B30 RID: 35632 RVA: 0x000429E4 File Offset: 0x00040BE4
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x00246BAC File Offset: 0x00244DAC
		// (set) Token: 0x06008B32 RID: 35634 RVA: 0x00042A03 File Offset: 0x00040C03
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar ParentAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_ParentAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x06008B33 RID: 35635 RVA: 0x00246BDC File Offset: 0x00244DDC
		// (set) Token: 0x06008B34 RID: 35636 RVA: 0x00042A22 File Offset: 0x00040C22
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x00246C0C File Offset: 0x00244E0C
		// (set) Token: 0x06008B36 RID: 35638 RVA: 0x00042A41 File Offset: 0x00040C41
		public unsafe Transform AvatarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_AvatarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06008B37 RID: 35639 RVA: 0x00246C3C File Offset: 0x00244E3C
		// (set) Token: 0x06008B38 RID: 35640 RVA: 0x00042A60 File Offset: 0x00040C60
		public unsafe float targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x04005E57 RID: 24151
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E58 RID: 24152
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoints;

		// Token: 0x04005E59 RID: 24153
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E5A RID: 24154
		private static readonly IntPtr NativeFieldInfoPtr_ParentAvatar;

		// Token: 0x04005E5B RID: 24155
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005E5C RID: 24156
		private static readonly IntPtr NativeFieldInfoPtr_AvatarContainer;

		// Token: 0x04005E5D RID: 24157
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04005E5E RID: 24158
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E5F RID: 24159
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E60 RID: 24160
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005E61 RID: 24161
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04005E62 RID: 24162
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E63 RID: 24163
		private static readonly IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_AvatarSettings_0;

		// Token: 0x04005E64 RID: 24164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005E65 RID: 24165
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Private_Void_0;

		// Token: 0x02000B15 RID: 2837
		[Serializable]
		public class SlotAlignmentPoint : Il2CppSystem.Object
		{
			// Token: 0x0600D6C4 RID: 54980 RVA: 0x00331AD4 File Offset: 0x0032FCD4
			// Note: this type is marked as 'beforefieldinit'.
			static SlotAlignmentPoint()
			{
				Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "SlotAlignmentPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr);
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "SlotType");
				CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, "Point");
				CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr, 100680588);
			}

			// Token: 0x0600D6C5 RID: 54981 RVA: 0x00331B3C File Offset: 0x0032FD3C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SlotAlignmentPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay.SlotAlignmentPoint>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.SlotAlignmentPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C6 RID: 54982 RVA: 0x0006884F File Offset: 0x00066A4F
			public SlotAlignmentPoint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004288 RID: 17032
			// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x00331B78 File Offset: 0x0032FD78
			// (set) Token: 0x0600D6C8 RID: 54984 RVA: 0x00068858 File Offset: 0x00066A58
			public unsafe EClothingSlot SlotType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_SlotType)) = value;
				}
			}

			// Token: 0x17004289 RID: 17033
			// (get) Token: 0x0600D6C9 RID: 54985 RVA: 0x00331BA0 File Offset: 0x0032FDA0
			// (set) Token: 0x0600D6CA RID: 54986 RVA: 0x00068873 File Offset: 0x00066A73
			public unsafe Transform Point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterDisplay.SlotAlignmentPoint.NativeFieldInfoPtr_Point), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400906E RID: 36974
			private static readonly IntPtr NativeFieldInfoPtr_SlotType;

			// Token: 0x0400906F RID: 36975
			private static readonly IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x04009070 RID: 36976
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
