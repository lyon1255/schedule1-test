using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004AE RID: 1198
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x060069A0 RID: 27040 RVA: 0x001D8D5C File Offset: 0x001D6F5C
		// Note: this type is marked as 'beforefieldinit'.
		static CallerID()
		{
			Il2CppClassPointerStore<CallerID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "CallerID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerID>.NativeClassPtr);
			CallerID.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "Name");
			CallerID.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "ProfilePicture");
			CallerID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerID>.NativeClassPtr, 100676712);
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x001D8DC8 File Offset: 0x001D6FC8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x00031EA9 File Offset: 0x000300A9
		public CallerID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x060069A3 RID: 27043 RVA: 0x001D8E04 File Offset: 0x001D7004
		// (set) Token: 0x060069A4 RID: 27044 RVA: 0x00031EB2 File Offset: 0x000300B2
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x001D8E2C File Offset: 0x001D702C
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x00031ED1 File Offset: 0x000300D1
		public unsafe Sprite ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400485D RID: 18525
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400485E RID: 18526
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400485F RID: 18527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
