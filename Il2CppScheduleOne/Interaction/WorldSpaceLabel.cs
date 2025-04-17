using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F4 RID: 1012
	public class WorldSpaceLabel : Il2CppSystem.Object
	{
		// Token: 0x0600541A RID: 21530 RVA: 0x0018B108 File Offset: 0x00189308
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceLabel()
		{
			Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "WorldSpaceLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr);
			WorldSpaceLabel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "text");
			WorldSpaceLabel.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "color");
			WorldSpaceLabel.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "position");
			WorldSpaceLabel.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "scale");
			WorldSpaceLabel.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "rect");
			WorldSpaceLabel.NativeFieldInfoPtr_textComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "textComp");
			WorldSpaceLabel.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "active");
			WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673790);
			WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673791);
			WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100673792);
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0018B200 File Offset: 0x00189400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179728, RefRangeEnd = 179729, XrefRangeStart = 179688, XrefRangeEnd = 179728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceLabel(string _text, Vector3 _position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0018B25C File Offset: 0x0018945C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179758, RefRangeEnd = 179760, XrefRangeStart = 179729, XrefRangeEnd = 179758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0018B290 File Offset: 0x00189490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179775, RefRangeEnd = 179776, XrefRangeStart = 179760, XrefRangeEnd = 179775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00028369 File Offset: 0x00026569
		public WorldSpaceLabel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x0600541F RID: 21535 RVA: 0x0018B2C4 File Offset: 0x001894C4
		// (set) Token: 0x06005420 RID: 21536 RVA: 0x00028372 File Offset: 0x00026572
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06005421 RID: 21537 RVA: 0x0018B2EC File Offset: 0x001894EC
		// (set) Token: 0x06005422 RID: 21538 RVA: 0x00028391 File Offset: 0x00026591
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06005423 RID: 21539 RVA: 0x0018B314 File Offset: 0x00189514
		// (set) Token: 0x06005424 RID: 21540 RVA: 0x000283AC File Offset: 0x000265AC
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x0018B33C File Offset: 0x0018953C
		// (set) Token: 0x06005426 RID: 21542 RVA: 0x000283C7 File Offset: 0x000265C7
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x0018B364 File Offset: 0x00189564
		// (set) Token: 0x06005428 RID: 21544 RVA: 0x000283E2 File Offset: 0x000265E2
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x0018B394 File Offset: 0x00189594
		// (set) Token: 0x0600542A RID: 21546 RVA: 0x00028401 File Offset: 0x00026601
		public unsafe Text textComp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x0018B3C4 File Offset: 0x001895C4
		// (set) Token: 0x0600542C RID: 21548 RVA: 0x00028420 File Offset: 0x00026620
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x04003900 RID: 14592
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04003901 RID: 14593
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04003902 RID: 14594
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04003903 RID: 14595
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04003904 RID: 14596
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04003905 RID: 14597
		private static readonly IntPtr NativeFieldInfoPtr_textComp;

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0;

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplay_Public_Void_0;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
	}
}
