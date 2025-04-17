using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071B RID: 1819
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x0600A3B5 RID: 41909 RVA: 0x00290F2C File Offset: 0x0028F12C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInfoContent()
		{
			Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr);
			QualityItemInfoContent.NativeFieldInfoPtr_Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "Star");
			QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "QualityLabel");
			QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683313);
			QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100683314);
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x00290FAC File Offset: 0x0028F1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286377, RefRangeEnd = 286378, XrefRangeStart = 286363, XrefRangeEnd = 286377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x00290FFC File Offset: 0x0028F1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x00050A40 File Offset: 0x0004EC40
		public QualityItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A3B9 RID: 41913 RVA: 0x00291038 File Offset: 0x0028F238
		// (set) Token: 0x0600A3BA RID: 41914 RVA: 0x00050A49 File Offset: 0x0004EC49
		public unsafe Image Star
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x00291068 File Offset: 0x0028F268
		// (set) Token: 0x0600A3BC RID: 41916 RVA: 0x00050A68 File Offset: 0x0004EC68
		public unsafe TextMeshProUGUI QualityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DC6 RID: 28102
		private static readonly IntPtr NativeFieldInfoPtr_Star;

		// Token: 0x04006DC7 RID: 28103
		private static readonly IntPtr NativeFieldInfoPtr_QualityLabel;

		// Token: 0x04006DC8 RID: 28104
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DC9 RID: 28105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
