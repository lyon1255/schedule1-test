using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059D RID: 1437
	[Serializable]
	public class PropertyContainer : Object
	{
		// Token: 0x06007DE6 RID: 32230 RVA: 0x0021B360 File Offset: 0x00219560
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContainer()
		{
			Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr);
			PropertyContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, "Property");
			PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, 100679040);
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x0021B3B8 File Offset: 0x002195B8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x0003BD60 File Offset: 0x00039F60
		public PropertyContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007DE9 RID: 32233 RVA: 0x0021B3F4 File Offset: 0x002195F4
		// (set) Token: 0x06007DEA RID: 32234 RVA: 0x0003BD69 File Offset: 0x00039F69
		public unsafe EProperty Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property)) = value;
			}
		}

		// Token: 0x040055B4 RID: 21940
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x040055B5 RID: 21941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
