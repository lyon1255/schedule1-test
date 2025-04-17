using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	public class GameSettings : Object
	{
		// Token: 0x06006251 RID: 25169 RVA: 0x001BF300 File Offset: 0x001BD500
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettings()
		{
			Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
			GameSettings.NativeFieldInfoPtr_ConsoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ConsoleEnabled");
			GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100675769);
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x001BF358 File Offset: 0x001BD558
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x0002E780 File Offset: 0x0002C980
		public GameSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x001BF394 File Offset: 0x001BD594
		// (set) Token: 0x06006255 RID: 25173 RVA: 0x0002E789 File Offset: 0x0002C989
		public unsafe bool ConsoleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled)) = value;
			}
		}

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleEnabled;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
