using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	public class ObjectListFieldData : Object
	{
		// Token: 0x06002FC0 RID: 12224 RVA: 0x001086DC File Offset: 0x001068DC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldData()
		{
			Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectListFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr);
			ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, "ObjectGUIDs");
			ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, 100668787);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00108734 File Offset: 0x00106934
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData(List<string> objectGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGUIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x000194C1 File Offset: 0x000176C1
		public ObjectListFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00108780 File Offset: 0x00106980
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x000194CA File Offset: 0x000176CA
		public unsafe List<string> ObjectGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeFieldInfoPtr_ObjectGUIDs;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;
	}
}
