using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006A5 RID: 1701
	public class AssetPathLink : MonoBehaviour
	{
		// Token: 0x0600983A RID: 38970 RVA: 0x0026DD14 File Offset: 0x0026BF14
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathLink()
		{
			Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "AssetPathLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr);
			AssetPathLink.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, "prefabID");
			AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, 100682090);
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x0026DD6C File Offset: 0x0026BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271784, XrefRangeEnd = 271788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetPathLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x0004A163 File Offset: 0x00048363
		public AssetPathLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x0026DDA8 File Offset: 0x0026BFA8
		// (set) Token: 0x0600983E RID: 38974 RVA: 0x0004A16C File Offset: 0x0004836C
		public unsafe string prefabID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400668B RID: 26251
		private static readonly IntPtr NativeFieldInfoPtr_prefabID;

		// Token: 0x0400668C RID: 26252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
