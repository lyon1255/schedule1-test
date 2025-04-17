using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000678 RID: 1656
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x060093DC RID: 37852 RVA: 0x002604A0 File Offset: 0x0025E6A0
		// Note: this type is marked as 'beforefieldinit'.
		static Tooltip()
		{
			Il2CppClassPointerStore<Tooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "Tooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tooltip>.NativeClassPtr);
			Tooltip.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "text");
			Tooltip.NativeFieldInfoPtr_labelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "labelOffset");
			Tooltip.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "rect");
			Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "<isWorldspace>k__BackingField");
			Tooltip.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "canvas");
			Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681618);
			Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681619);
			Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681620);
			Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681621);
			Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100681622);
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x00260598 File Offset: 0x0025E798
		public unsafe Vector3 labelPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 265864, RefRangeEnd = 265865, XrefRangeStart = 265861, XrefRangeEnd = 265864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x060093DE RID: 37854 RVA: 0x002605D4 File Offset: 0x0025E7D4
		// (set) Token: 0x060093DF RID: 37855 RVA: 0x00260610 File Offset: 0x0025E810
		public unsafe bool isWorldspace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00260650 File Offset: 0x0025E850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265865, XrefRangeEnd = 265890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x0026068C File Offset: 0x0025E88C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x00047B5A File Offset: 0x00045D5A
		public Tooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x060093E3 RID: 37859 RVA: 0x002606C8 File Offset: 0x0025E8C8
		// (set) Token: 0x060093E4 RID: 37860 RVA: 0x00047B63 File Offset: 0x00045D63
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x060093E5 RID: 37861 RVA: 0x002606F0 File Offset: 0x0025E8F0
		// (set) Token: 0x060093E6 RID: 37862 RVA: 0x00047B82 File Offset: 0x00045D82
		public unsafe Vector2 labelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset)) = value;
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x060093E7 RID: 37863 RVA: 0x00260718 File Offset: 0x0025E918
		// (set) Token: 0x060093E8 RID: 37864 RVA: 0x00047B9D File Offset: 0x00045D9D
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x060093E9 RID: 37865 RVA: 0x00260748 File Offset: 0x0025E948
		// (set) Token: 0x060093EA RID: 37866 RVA: 0x00047BBC File Offset: 0x00045DBC
		public unsafe bool _isWorldspace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x060093EB RID: 37867 RVA: 0x00260770 File Offset: 0x0025E970
		// (set) Token: 0x060093EC RID: 37868 RVA: 0x00047BD7 File Offset: 0x00045DD7
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063C6 RID: 25542
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040063C7 RID: 25543
		private static readonly IntPtr NativeFieldInfoPtr_labelOffset;

		// Token: 0x040063C8 RID: 25544
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x040063C9 RID: 25545
		private static readonly IntPtr NativeFieldInfoPtr__isWorldspace_k__BackingField;

		// Token: 0x040063CA RID: 25546
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040063CB RID: 25547
		private static readonly IntPtr NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0;

		// Token: 0x040063CC RID: 25548
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0;

		// Token: 0x040063CD RID: 25549
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0;

		// Token: 0x040063CE RID: 25550
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040063CF RID: 25551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
