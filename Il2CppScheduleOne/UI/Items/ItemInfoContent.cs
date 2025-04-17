using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000716 RID: 1814
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x0600A31E RID: 41758 RVA: 0x0028F234 File Offset: 0x0028D434
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoContent()
		{
			Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr);
			ItemInfoContent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "Height");
			ItemInfoContent.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "NameLabel");
			ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, "DescriptionLabel");
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683258);
			ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683259);
			ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr, 100683260);
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0028F2DC File Offset: 0x0028D4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285529, XrefRangeEnd = 285530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x0028F32C File Offset: 0x0028D52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285530, XrefRangeEnd = 285531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0028F37C File Offset: 0x0028D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285531, XrefRangeEnd = 285532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x000504A3 File Offset: 0x0004E6A3
		public ItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A323 RID: 41763 RVA: 0x0028F3B8 File Offset: 0x0028D5B8
		// (set) Token: 0x0600A324 RID: 41764 RVA: 0x000504AC File Offset: 0x0004E6AC
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A325 RID: 41765 RVA: 0x0028F3E0 File Offset: 0x0028D5E0
		// (set) Token: 0x0600A326 RID: 41766 RVA: 0x000504C7 File Offset: 0x0004E6C7
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x0028F410 File Offset: 0x0028D610
		// (set) Token: 0x0600A328 RID: 41768 RVA: 0x000504E6 File Offset: 0x0004E6E6
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoContent.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D68 RID: 28008
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04006D69 RID: 28009
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006D6A RID: 28010
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006D6B RID: 28011
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006D6C RID: 28012
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemDefinition_0;

		// Token: 0x04006D6D RID: 28013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
