using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050F RID: 1295
	public class PropertyContentsContainer : MonoBehaviour
	{
		// Token: 0x0600732A RID: 29482 RVA: 0x001F6FE0 File Offset: 0x001F51E0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContentsContainer()
		{
			Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyContentsContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr);
			PropertyContentsContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, "Property");
			PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100677759);
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x001F7038 File Offset: 0x001F5238
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContentsContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00036C58 File Offset: 0x00034E58
		public PropertyContentsContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x001F7074 File Offset: 0x001F5274
		// (set) Token: 0x0600732E RID: 29486 RVA: 0x00036C61 File Offset: 0x00034E61
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E9E RID: 20126
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004E9F RID: 20127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
