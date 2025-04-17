using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000715 RID: 1813
	public class ItemDefinitionInfoHoverable : MonoBehaviour
	{
		// Token: 0x0600A319 RID: 41753 RVA: 0x0028F170 File Offset: 0x0028D370
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinitionInfoHoverable()
		{
			Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemDefinitionInfoHoverable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr);
			ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, "AssignedItem");
			ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, 100683257);
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x0028F1C8 File Offset: 0x0028D3C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0005047B File Offset: 0x0004E67B
		public ItemDefinitionInfoHoverable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A31C RID: 41756 RVA: 0x0028F204 File Offset: 0x0028D404
		// (set) Token: 0x0600A31D RID: 41757 RVA: 0x00050484 File Offset: 0x0004E684
		public unsafe ItemDefinition AssignedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D66 RID: 28006
		private static readonly IntPtr NativeFieldInfoPtr_AssignedItem;

		// Token: 0x04006D67 RID: 28007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
