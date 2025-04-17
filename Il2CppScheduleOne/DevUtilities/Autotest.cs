using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Tiles;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044E RID: 1102
	public class Autotest : MonoBehaviour
	{
		// Token: 0x06005FB0 RID: 24496 RVA: 0x001B6FE4 File Offset: 0x001B51E4
		// Note: this type is marked as 'beforefieldinit'.
		static Autotest()
		{
			Il2CppClassPointerStore<Autotest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Autotest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Autotest>.NativeClassPtr);
			Autotest.NativeFieldInfoPtr_workerAccom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "workerAccom");
			Autotest.NativeFieldInfoPtr_crescentGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "crescentGrid");
			Autotest.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675506);
			Autotest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675507);
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x001B7064 File Offset: 0x001B5264
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x001B7098 File Offset: 0x001B5298
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Autotest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Autotest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x0002D239 File Offset: 0x0002B439
		public Autotest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x001B70D4 File Offset: 0x001B52D4
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x0002D242 File Offset: 0x0002B442
		public unsafe Constructable_GridBased workerAccom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x001B7104 File Offset: 0x001B5304
		// (set) Token: 0x06005FB7 RID: 24503 RVA: 0x0002D261 File Offset: 0x0002B461
		public unsafe Grid crescentGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeFieldInfoPtr_workerAccom;

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeFieldInfoPtr_crescentGrid;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
