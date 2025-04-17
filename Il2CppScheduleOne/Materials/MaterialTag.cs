using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Materials
{
	// Token: 0x0200037A RID: 890
	public class MaterialTag : MonoBehaviour
	{
		// Token: 0x060045C5 RID: 17861 RVA: 0x001577CC File Offset: 0x001559CC
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialTag()
		{
			Il2CppClassPointerStore<MaterialTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Materials", "MaterialTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr);
			MaterialTag.NativeFieldInfoPtr_MaterialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, "MaterialType");
			MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, 100671881);
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00157824 File Offset: 0x00155A24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00021F5E File Offset: 0x0002015E
		public MaterialTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x00157860 File Offset: 0x00155A60
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x00021F67 File Offset: 0x00020167
		public unsafe EMaterialType MaterialType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType)) = value;
			}
		}

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeFieldInfoPtr_MaterialType;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
